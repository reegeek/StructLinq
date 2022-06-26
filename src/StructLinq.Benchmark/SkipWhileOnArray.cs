using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class SkipWhileOnArray
    {
        private const int Count = 10_000;
        public int[] array;

        public SkipWhileOnArray()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array.SkipWhile(x=> x < 5000))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().SkipWhile(x=> x < 5000))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().SkipWhile(x=> x < 5000, x=>x))
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqFunctionZeroAlloc()
        {
            var sum = 0;
            var predicate = new Predicate();
            foreach (var i in array.ToStructEnumerable().SkipWhile(predicate, x=>x))
            {
                sum += i;
            }

            return sum;
        }

        private struct Predicate : IFunction<int, bool>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Eval(int element)
            {
                return element < 5000;
            }
        }

    }
}
