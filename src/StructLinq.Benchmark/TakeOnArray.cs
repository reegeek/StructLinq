using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class TakeOnArray
    {
        private const int Count = 10000;
        private const int TakeCount = 5000;
        public int[] array;

        public TakeOnArray()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Take(TakeCount))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Take(TakeCount))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqFaster()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Take(TakeCount, x=>x))
            {
                sum += i;
            }

            return sum;
        }

    }
}
