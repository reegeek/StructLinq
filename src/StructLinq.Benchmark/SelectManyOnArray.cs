using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;


namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class SelectManyOnArray
    {
        private int[][] array;
        private const int Count = 1000;

        public SelectManyOnArray()
        {
            array = Enumerable.Range(0, Count)
                .Select(x => Enumerable.Range(0, x).ToArray())
                .ToArray();
        }
        
        [Benchmark(Baseline = true)]
        public int LINQ()
        {
            var sum = 0;
            foreach (var i in array.SelectMany(x=> x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQ()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().SelectMany(x=> x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLINQWhereReturnIsStructEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().SelectMany(x=> x.ToStructEnumerable(),  _ => _, _ => _))
            {
                sum += i;
            }

            return sum;
        }


        [Benchmark]
        public int StructLINQWithFunction()
        {
            var sum = 0;
            var func = new SelectManyFunction();
            foreach (var i in array.ToStructEnumerable().SelectMany(func, x=>x, x=> x, x=> x))
            {
                sum += i;
            }

            return sum;
        }

        internal struct SelectManyFunction : IFunction<int[], ArrayEnumerable<int>>
        {
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public ArrayEnumerable<int> Eval(int[] element)
            {
                return element.ToStructEnumerable();
            }
        }
    }
}