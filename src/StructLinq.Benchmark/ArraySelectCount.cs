using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArraySelectCount
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ArraySelectCount()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark]
        public int Linq()
        {
            return array.Select(x => x * 2).Count();
        }

        [Benchmark]
        public int StructLinq()
        {
            return array.ToStructEnumerable().Select(x => x * 2).Count();
        }

        [Benchmark]
        public int StructLinqZeroAlloc()
        {
            var select = new SelectFunction();
            return array.ToStructEnumerable().Select(ref select, x=> x, x=> x).Count(x=>x);
        }

    }
}
