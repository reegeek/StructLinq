using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [DisassemblyDiagnoser(recursiveDepth: 4),MemoryDiagnoser]
    public class ContainsWhere
    {
        private const int Count = 10_000;
        private readonly int[] array;
        private readonly IEnumerable<int> enumerable;

        
        public ContainsWhere()
        {
            array = Enumerable.Range(0, Count).ToArray();
            enumerable = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public bool Linq()
        {
            return enumerable.Where(x=> true).Contains(5_000);
        }

        [Benchmark]
        public bool Array()
        {
            return array.Where(x=> true).Contains(5_000);
        }

        [Benchmark]
        public bool StructLinq()
        {
            return array.ToStructEnumerable().Where(x=> true).Contains(5_000);
        }

        [Benchmark]
        public bool StructLinqZeroAlloc()
        {
            return array.ToStructEnumerable().Where(x=> true, x=> x).Contains(5_000, x=> x);
        }
    }
}
