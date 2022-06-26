using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class SelectOnArray
    {
        private int[] array;
        private const int Count = 10000;

        public SelectOnArray()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }
        
        [Benchmark(Baseline = true)]
        public double Handmaded()
        {
            var sum = 0.0;
            foreach (var i in array)
            {
                var x = i * 2.0;
                sum += x;
            }

            return sum;
        }

        [Benchmark]
        public double LINQ()
        {
            var sum = 0.0;
            foreach (var i in array.Select(x=> x * 2.0))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public double StructLINQ()
        {
            var sum = 0.0;
            foreach (var i in array.ToStructEnumerable().Select(x=> x * 2.0, x=>x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public double StructLINQWithFunction()
        {
            var sum = 0.0;
            var func = new MultFunction();
            foreach (var i in array.ToStructEnumerable().Select(ref func, x=>x, x=> x))
            {
                sum += i;
            }

            return sum;
        }
    }
}
