using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //BenchmarkDotNet = v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-8750H CPU 2.20GHz(Coffee Lake), 1 CPU, 12 logical and 6 physical cores
    //.NET Core SDK = 3.1.200

    //[Host]     : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.2 (CoreCLR 4.700.20.6602, CoreFX 4.700.20.6702), X64 RyuJIT

    //|                                Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|-------------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|                         HandmadedCode |  5.579 us | 0.0414 us | 0.0346 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|                               SysLinq | 48.360 us | 0.5377 us | 0.4767 us |  8.67 |    0.06 |     - |     - |     - |     104 B |
    //| StructRangeWhereSelectSumWithDelegate | 40.848 us | 0.3137 us | 0.2935 us |  7.31 |    0.06 |     - |     - |     - |      40 B |
    //|             StructRangeWhereSelectSum | 13.703 us | 0.0452 us | 0.0378 us |  2.46 |    0.02 |     - |     - |     - |         - |

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