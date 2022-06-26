using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class SelectOnArrayOfClass
    {
        private Container[] array;
        private const int Count = 10000;

        public SelectOnArrayOfClass()
        {
            array = Enumerable.Range(0, Count).Select(x=> new Container(x)).ToArray();
        }
        
        [Benchmark(Baseline = true)]
        public int Handmaded()
        {
            var sum = 0;
            foreach (var i in array)
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int LINQ()
        {
            var sum = 0;
            foreach (var i in array.Select(x=> x.Element))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQ()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Select(x=> x.Element, x=>x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQWithFunction()
        {
            var sum = 0;
            var func = new ContainerSelect();
            foreach (var i in array.ToStructEnumerable().Select(ref func, x=>x, x=> x))
            {
                sum += i;
            }

            return sum;
        }
    }
}
