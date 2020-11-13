using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser, DisassemblyDiagnoser(4)]
    public class OrderByArrayOfInt
    {
        private const int Count = 10_000;
        private int[] array;

        public OrderByArrayOfInt()
        {
            var rand = new Random(42);
            var list = new List<int>();
            for (int i = 0; i < Count; i++)
            {
                list.Add(rand.Next());
            }
            array = list.ToArray();
        }

        [Benchmark(Baseline = true)]
        public int LINQ()
        {
            var sum = 0;
            foreach (var i in array.OrderBy(x=> x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqOrder()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().Order())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqOrderBy()
        {
            var sum = 0;
            Func<int, int> func = i => i;
            foreach (var i in array.ToStructEnumerable().OrderBy(func))
            {
                sum += i;
            }

            return sum;
        }


        [Benchmark]
        public int StructLinqOrderZeroAlloc()
        {
            var sum = 0;
            var comparer = new IntComparer();
            foreach (var i in array.ToStructEnumerable().Order(ref comparer, x => x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqOrderByZeroAlloc()
        {
            var sum = 0;
            var comparer = new IntComparer();
            var func = new Identity<int>();
            foreach (var i in array.ToStructEnumerable().OrderBy(ref func, ref comparer, x => x, x=> x))
            {
                sum += i;
            }

            return sum;
        }

    }

    public struct Identity<T> : IFunction<T, T>
    {
        public T Eval(T element)
        {
            return element;
        }
    }
}
