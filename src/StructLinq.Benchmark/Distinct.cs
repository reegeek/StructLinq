using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Distinct
    {
        private const int Count = 10_000;
        private readonly int[] array;
        private readonly IEqualityComparer<int> comparer = EqualityComparer<int>.Default;
        
        public Distinct()
        {
            var tmp = Enumerable.Range(0, Count).ToArray();
            var list = new List<int>(tmp);
            list.AddRange(tmp);
            array = list.ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Distinct())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Distinct(x=>x))
            {
                sum += i;
            }

            return sum;
        }

    }
}