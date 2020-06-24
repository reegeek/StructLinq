using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.301
    //[Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


    //```
    //|                                Method |     Mean |    Error |   StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------------------------- |---------:|---------:|---------:|------:|------:|------:|------:|----------:|
    //|                         HandmadedCode | 12.58 us | 0.010 us | 0.010 us |  1.00 |     - |     - |     - |         - |
    //|                               SysLinq | 44.92 us | 0.055 us | 0.052 us |  3.57 |     - |     - |     - |     104 B |
    //| StructRangeWhereSelectSumWithDelegate | 44.88 us | 0.043 us | 0.040 us |  3.57 |     - |     - |     - |      48 B |
    //|             StructRangeWhereSelectSum | 15.08 us | 0.054 us | 0.050 us |  1.20 |     - |     - |     - |         - |

    [MemoryDiagnoser]
    public class ArrayWhereSelectSum
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ArrayWhereSelectSum()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }
        [Benchmark(Baseline = true)]
        public int HandmadedCode()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var elt = array[i];
                if ((elt & 1) == 0)
                {
                    var mult = elt * 2;
                    sum += mult;
                }
            }
            return sum;
        }
        [Benchmark]
        public int SysLinq() => array
            .Where(x => (x & 1) == 0)
            .Select(x => x * 2)
            .Sum();

        [Benchmark]
        public int StructRangeWhereSelectSumWithDelegate() => array
            .ToStructEnumerable()
            .Where(x => (x & 1) == 0, x => x)
            .Select(x => x * 2, x => x)
            .Sum();

        [Benchmark]
        public int StructRangeWhereSelectSum()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            return array
                .ToStructEnumerable()
                .Where(ref @where, x => x)
                .Select(ref @select, x => x, x => x)
                .Sum(x => x);
        }
    }
}