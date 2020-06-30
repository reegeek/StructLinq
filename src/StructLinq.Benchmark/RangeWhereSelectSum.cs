using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.101
    //[Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


    //```
    //|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|---------------------------------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|                            SysSum |  7.721 us | 0.0110 us | 0.0103 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|            SysRangeWhereSelectSum | 95.588 us | 0.6049 us | 0.5658 us | 12.38 |    0.08 |     - |     - |     - |     105 B |
    //| ConvertWhereSelectSumWithDelegate | 96.534 us | 1.8448 us | 1.5405 us | 12.50 |    0.20 |     - |     - |     - |      41 B |
    //|   ConvertWhereSelectSumWithStruct | 53.105 us | 0.3606 us | 0.3373 us |  6.88 |    0.04 |     - |     - |     - |      41 B |
    //|         StructRangeWhereSelectSum | 16.708 us | 0.0145 us | 0.0136 us |  2.16 |    0.00 |     - |     - |     - |         - |

    [MemoryDiagnoser]
    public class RangeWhereSelectSum
    {
        private const int Count = 10000;
        public RangeWhereSelectSum()
        {
        }
        
        [Benchmark(Baseline = true)]
        public int SysSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                if ((i & 1) == 0)
                {
                    var mult = i * 2;
                    sum += mult;
                }
            }
            return sum;
        }

        [Benchmark]
        public int SysRangeWhereSelectSum() => Enumerable.Range(0, Count)
                                                         .Where(x=> (x & 1)==0)
                                                         .Select(x=> x * 2)
                                                         .Sum();

        [Benchmark]
        public int ConvertWhereSelectSumWithDelegate() => Enumerable.Range(0, Count)
                                                                    .ToStructEnumerable()
                                                                    .Where(x => (x & 1) == 0, x=>x)
                                                                    .Select(x => x *2, x => x)
                                                                    .Sum();

        [Benchmark]
        public int StructRangeWhereSelectSum()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            return StructEnumerable.Range(0, Count)
                                   .Where(ref @where, x => x)
                                   .Select(ref @select, x => x, x => x)
                                   .Sum(x=>x);
        }
    }

    struct WherePredicate : IFunction<int, bool>
    {
        public readonly bool Eval(int element)
        {
            return (element & 1) == 0;
        }
    }

    struct SelectFunction : IFunction<int, int>
    {
        public readonly int Eval(int element)
        {
            return element * 2;
        }
    }
}