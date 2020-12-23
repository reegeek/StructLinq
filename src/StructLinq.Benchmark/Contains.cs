using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [DisassemblyDiagnoser(4),MemoryDiagnoser]
    public class Contains
    {
        private const int Count = 10_000;
        private readonly int[] array;

        
        public Contains()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public bool Array()
        {
            return array.Contains(5_000);
        }

        [Benchmark]
        public bool StructLinq()
        {
            return array.ToStructEnumerable().Contains(5_000);
        }

        [Benchmark]
        public bool StructLinqZeroAlloc()
        {
            return array.ToStructEnumerable().Contains(5_000, x=> x);
        }
    }
}
