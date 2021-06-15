using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class SumOnSelectMany
    {
        private int[][] array;
        private const int Count = 1000;

        public SumOnSelectMany()
        {
            array = Enumerable.Range(0, Count)
                .Select(x => Enumerable.Range(0, x).ToArray())
                .ToArray();
        }
        
        [Benchmark(Baseline = true)]
        public int LINQ()
        {
            return array.SelectMany(x => x).Sum();
        }

        [Benchmark]
        public int StructLINQ()
        {
            return array.ToStructEnumerable().SelectMany(x => x).Sum();
        }

        [Benchmark]
        public int StructLINQWhereReturnIsStructEnumerable()
        {
            return array.ToStructEnumerable().SelectMany(x => x.ToStructEnumerable(), _ => _, _ => _).Sum(x => x);
        }


        [Benchmark]
        public int StructLINQWithFunction()
        {
            var func = new SelectManyFunction();
            return array.ToStructEnumerable().SelectMany(func, x => x, x => x, x => x).Sum(x => x);
        }

        [Benchmark]
        public int StructLINQWithFunctionWithForeach()
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