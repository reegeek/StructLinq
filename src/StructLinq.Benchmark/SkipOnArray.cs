using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser, DisassemblyDiagnoser( 4)]
    public class SkipOnArray
    {
        private const int Count = 10000;
        public int[] array;

        public SkipOnArray()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.Skip(1000))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Skip(1000))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqFaster()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Skip(1000, x=>x))
            {
                sum += i;
            }

            return sum;
        }

    }
}
