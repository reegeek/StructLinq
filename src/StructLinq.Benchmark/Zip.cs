using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Zip
    {
        private const int Count1 = 10000;
        private const int Count2 = 5000;
        public int[] array1;
        public int[] array2;

        public Zip()
        {
            array1 = Enumerable.Range(0, Count1).ToArray();
            array2 = Enumerable.Range(0, Count2).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
#if !NETFRAMEWORK
            foreach (var i in array1.Zip(array2))
            {
                sum += i.First + i.Second;
            }
#else
            foreach (var i in array1.Zip(array2, (i, i1) => (i, i1)))
            {
                sum += i.Item1 + i.Item2;
            }
#endif

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array1.ToStructEnumerable().Zip(array2.ToStructEnumerable()))
            {
                sum += i.Item1 + i.Item2;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqFunction()
        {
            var sum = 0;
            foreach (var i in array1.ToStructEnumerable().Zip(array2.ToStructEnumerable(), x=> x, x=>x))
            {
                sum += i.Item1 + i.Item2;
            }

            return sum;
        }

    }
}
