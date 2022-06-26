using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class WhereOnArrayOfClass
    {
        private Container[] array;
        private const int Count = 10000;

        public WhereOnArrayOfClass()
        {
            array = Enumerable.Range(0, Count).Select(x=> new Container(x)).ToArray();
        }
        
        [Benchmark(Baseline = true)]
        public int Handmaded()
        {
            var sum = 0;
            foreach (var i in array)
            {
                if (i.Element % 2 == 0)
                    sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int LINQ()
        {
            var sum = 0;
            foreach (var i in array.Where(x=> x.Element % 2 == 0))
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQ()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Where(x=> x.Element % 2 == 0, x=>x))
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQWithFunction()
        {
            var sum = 0;
            var func = new WhereFunc();
            foreach (var i in array.ToStructEnumerable().Where(ref func, x=>x))
            {
                sum += i.Element;
            }

            return sum;
        }
        
        private readonly struct WhereFunc : IFunction<Container, bool>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Eval(Container element)
            {
                return element.Element % 2 == 0;
            }
        }
    }
}
