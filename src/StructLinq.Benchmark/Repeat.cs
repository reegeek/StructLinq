using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser]
    public class Repeat
    {
        private const int Count = 10000;
        private const int value = 12;
        
        [Benchmark(Baseline = true)]
        public int EnumerableRepeat()
        {
            int sum = 0;
            foreach (var result in Enumerable.Repeat(value, Count))
            {
                sum += result;
            }

            return sum;
        }

        [Benchmark]
        public int StructEnumerableRepeat()
        {
            int sum = 0;
            foreach (var result in StructEnumerable.Repeat(value, Count))
            {
                sum += result;
            }

            return sum;
        }


    }
}
