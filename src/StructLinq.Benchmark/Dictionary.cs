using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48, baseline:true)]
    [SimpleJob(RuntimeMoniker.Net60)]
    [SimpleJob(RuntimeMoniker.Net70)]
    public class Dictionary
    {

        private Dictionary<int, string> dico;

        [Params(2, 100, 1000)]
        public int ItemCount { get; set; }
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            dico = Enumerable
                   .Range(0, ItemCount)
                   .ToDictionary(x=> x, x=> x.ToString());
        }

        [Benchmark(Baseline = true)]
        public int LINQ()
        {
            var sum = 0;
            foreach (var keyValuePair in dico)
            {
                sum += keyValuePair.Key;
                sum += keyValuePair.Value.Length;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQ()
        {
            var sum = 0;
            foreach (var keyValuePair in dico.ToStructEnumerable())
            {
                sum += keyValuePair.Key;
                sum += keyValuePair.Value.Length;
            }

            return sum;
        }

    }
}
