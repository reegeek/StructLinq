using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class AllOnArray
    {
        private const int Count = 1000;
        private readonly int[] array;
        public AllOnArray()
        {
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
        }

        [Benchmark]
        public bool For()
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] >= Count / 2)
                    return false;
            }

            return true;
        }

        [Benchmark(Baseline = true)]
        public bool Linq() => array.All(x=> x < Count / 2);

        [Benchmark]
        public bool StructLinq() => array.ToStructEnumerable().All(x => x < Count /2);

        [Benchmark]
        public bool StructLinqZeroAlloc() => array.ToStructEnumerable().All(x => x < Count /2, x=>x );

        [Benchmark]
        public bool StructLinqIFunctionZeroAlloc()
        {
            var func = new AllFunction();
            return array.ToStructEnumerable().All(ref func, x => x);
        }

        private struct AllFunction : IFunction<int, bool>
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Eval(int element)
            {
                return element < Count / 2;
            }
        }
    }
}
