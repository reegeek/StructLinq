using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class WhereOnArray
    {
        private int[] array;
        private const int Count = 10000;

        public WhereOnArray()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }
        
        [Benchmark(Baseline = true)]
        public int Handmaded()
        {
            var sum = 0;
            foreach (var i in array)
            {
                if (i % 2 == 0)
                    sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int LINQ()
        {
            var sum = 0;
            foreach (var i in array.Where(x=> x % 2 == 0))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQ()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Where(x=> x % 2 == 0, x=>x))
            {
                sum += i;
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
                sum += i;
            }

            return sum;
        }
        
        private readonly struct WhereFunc : IFunction<int, bool>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Eval(int element)
            {
                return element % 2 == 0;
            }
        }
    }
}
