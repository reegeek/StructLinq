using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser]
    public class Select
    {
        private const int Count = 10000;
        public Select()
        {
        }

        [Benchmark(Baseline = true)]
        public double SysSelect()
        {
            return Enumerable.Range(0, Count).Select(x=> x * 2.0).Sum();
        }

        [Benchmark]
        public double DelegateSelect()
        {
            return StructEnumerable
                   .Range(0, Count)
                   .Select(x => x * 2.0)
                   .Sum();
        }

        [Benchmark]
        public double StructSelect()
        {
            var multFunction = new MultFunction();
            return StructEnumerable.Range(0, Count)
                            .Select(ref multFunction, x=>x)
                            .Sum(x=> x);
        }

        [Benchmark]
        public double ConvertSelect()
        {
            var multFunction = new MultFunction();
            return Enumerable.Range(0, Count)
                      .ToStructEnumerable()
                      .Select(ref multFunction, x => x)
                      .Sum(x=>x);
        }
    }

    readonly struct MultFunction : IFunction<int, double>
    {
        public double Eval(int element)
        {
            return element * 2.0;
        }
    }
}