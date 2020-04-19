using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ForEachDuckTyping
    {
        private const int Count = 10000;
        private readonly int[] array;
        private readonly IEnumerable<int> sysEnumerable;
        private readonly ArrayEnumerable<int> arrayEnumerable;
        private readonly IEnumerable<int> arrayEnumerableAsIEnumerable;

        public ForEachDuckTyping()
        {
            array = Enumerable.Range(0, Count).ToArray();
            sysEnumerable = Enumerable.Range(0, Count).ToArray();
            arrayEnumerable = Enumerable.Range(0, Count).ToArray().ToStructEnumerable();
            arrayEnumerableAsIEnumerable = Enumerable.Range(0, Count).ToArray().ToStructEnumerable().ToEnumerable();
        }

        [Benchmark(Baseline = true)]
        public int ForEachOnArray()
        {
            var sum = 0;
            foreach (var i in array)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnIEnumerable()
        {
            var sum = 0;
            foreach (var i in sysEnumerable)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnArrayStructEnumerable()
        {
            var sum = 0;
            foreach (var i in arrayEnumerable)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnArrayStructEnumerableAsIEnumerable()
        {
            var sum = 0;
            foreach (var i in arrayEnumerableAsIEnumerable)
            {
                sum += i;
            }
            return sum;
        }
    }
}