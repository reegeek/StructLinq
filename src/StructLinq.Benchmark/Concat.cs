using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Concat
    {
        private const int Count = 5_000;
        private readonly int[] array1;
        private readonly int[] array2;

        public Concat()
        {
            array1 = Enumerable.Range(0, Count).ToArray();
            array2 = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array1.Concat(array2))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array1.ToStructEnumerable().Concat(array2.ToStructEnumerable()))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var sum = 0;
            foreach (var i in array1.ToStructEnumerable().Concat(array2.ToStructEnumerable(), x=>x , x=> x))
            {
                sum += i;
            }

            return sum;
        }

    }
}
