using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    
    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
    public class ForEachDuckTyping
    {
        private const int Count = 10_000;
        private readonly int[] array;
        private readonly IEnumerable<int> sysEnumerable;

        public ForEachDuckTyping()
        {
            array = Enumerable.Range(0, Count).ToArray();
            sysEnumerable = Enumerable.Range(0, Count).ToArray();
        }

        private IEnumerable<int> YieldEnumerable()
        {
            var arrayLength = array.Length;
            var tab = array;
            for (int i = 0; i < arrayLength; i++)
            {
                yield return tab[i];
            }
        }

        [Benchmark(Baseline = true)]
        public int ForOnArray()
        {
            var sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }


        [Benchmark]
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
        public int ForEachOnYieldEnumerable()
        {
            var sum = 0;
            foreach (var i in YieldEnumerable())
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
            foreach (var i in array.ToStructEnumerable())
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnArrayStructEnumerableAsIEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable().ToEnumerable())
            {
                sum += i;
            }
            return sum;
        }
    }
}