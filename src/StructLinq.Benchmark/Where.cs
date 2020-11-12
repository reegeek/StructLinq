using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser, DisassemblyDiagnoser( 4)]
    public class Where
    {
        private const int Count = 10000;

        [Benchmark(Baseline = true)]
        public int SysSelect()
        {
            return Enumerable.Range(0, Count).Where(x => x > 0).Sum();
        }

        [Benchmark]
        public int DelegateSelect()
        {
            return StructEnumerable.Range(0, Count)
                                   .Where(x => x > 0)
                                   .Sum();
        }

        [Benchmark]
        public int StructSelect()
        {
            var predicate = new WhereFunc();
            return StructEnumerable.Range(0, Count).Where(ref predicate, x => x).Sum(x => x);
        }

        [Benchmark]
        public int ConvertSelect()
        {
            var predicate = new WhereFunc();
            return Enumerable.Range(0, Count).ToStructEnumerable().Where(ref predicate, x => x).Sum(x => x);
        }
    }

    struct WhereFunc : IFunction<int, bool>
    {
        public readonly bool Eval(int element)
        {
            return element > 0;
        }
    }
}

    