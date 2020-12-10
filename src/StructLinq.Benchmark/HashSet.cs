using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48, baseline:true)]
    [SimpleJob(RuntimeMoniker.NetCoreApp50)]
    public class HashSet
    {

        private HashSet<int> hashset;

        [Params(2, 100, 1000)]
        public int ItemCount { get; set; }
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            hashset = Enumerable
                      .Range(0, ItemCount)
                      .ToHashSet();
        }

        [Benchmark(Baseline = true)]
        public int LINQ()
        {
            var sum = 0;
            foreach (var i in hashset)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQ()
        {
            var sum = 0;
            foreach (var i in hashset.ToStructEnumerable())
            {
                sum += i;
            }

            return sum;
        }

    }
}
