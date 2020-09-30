using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Reverse
    {
        private const int Count = 10000;
        private readonly int[] array;

        public Reverse()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Reverse())
            {
                sum += i;

            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Reverse())
            {
                sum += i;

            }

            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Reverse(x=>x))
            {
                sum += i;

            }

            return sum;
        }
    }
}
