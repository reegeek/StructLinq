using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class SumOnList
    {
        private readonly List<int> list;
        public SumOnList()
        {
            list = Enumerable.Range(-1, 10000).ToList();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            return list.Sum();
        }

        [Benchmark]
        public int StructLinq()
        {
            return list.ToStructEnumerable().Sum(x => x);
        }
    }

}