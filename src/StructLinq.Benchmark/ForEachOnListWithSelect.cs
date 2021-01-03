using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ForEachOnListWithSelect
    {
        private readonly List<int> list;
        public ForEachOnListWithSelect()
        {
            list = Enumerable.Range(-1, 10000).ToList();
        }

        [Benchmark(Baseline = true)]
        public int LINQ()
        {
            var sum = 0;
            foreach (var i in list.Select(x=> x * 2))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqWithFunc()
        {
            var sum = 0;
            foreach (var i in list.ToStructEnumerable().Select(x=> x * 2, x=>x))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinqWithFuncAsEnumerable()
        {
            var sum = 0;
            foreach (var i in list.ToStructEnumerable().Select(x=> x * 2, x=>x).ToEnumerable())
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinqWithStructFunc()
        {
            var sum = 0;
            var func = new Mult2();
            foreach (var i in list.ToStructEnumerable().Select(ref func, x=> x, x=> x))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinqWithStructFuncAsEnumerable()
        {
            var sum = 0;
            var func = new Mult2();
            foreach (var i in list.ToStructEnumerable().Select(ref func, x=> x, x=> x).ToEnumerable())
            {
                sum += i;
            }
            return sum;
        }


        public readonly struct Mult2 : IFunction<int, int>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int Eval(int element)
            {
                return element * 2;
            }
        }

    }
}
