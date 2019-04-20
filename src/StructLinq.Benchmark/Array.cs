using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.IEnumerable;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Array
    {
        private readonly ITypedEnumerable<int, ArrayStructEnumerator<int>> safeArray;
        private readonly CountAction<int>[] countActions = new CountAction<int>[1];
        public int Count = 10000;
        private readonly IEnumerable<int> sysEnumerable;
        private readonly ITypedEnumerable<int, GenericEnumerator<int>> convertArray;
        private readonly int[] array;
        public Array()
        {
            array = Enumerable.Range(0, Count).ToArray();
            sysEnumerable = array;
            safeArray = array.ToTypedEnumerable();
            convertArray = ((IEnumerable<int>) array).ToTypedEnumerable();
        }

        [Benchmark(Baseline = true)]
        public int EnumArray()
        {
            int count = 0;
            foreach (var i in sysEnumerable)
            {
                count++;
            }
            return count;
        }

        [Benchmark]
        public int SysArray()
        {
            int count = 0;
            foreach (var i in array)
            {
                count++;
            }
            return count;
        }

        [Benchmark]
        public int UnsafeArray()
        {
            ref CountAction<int> countAction = ref countActions[0];
            countAction.Count = 0;
            safeArray.ForEach(ref countAction);
            return countAction.Count;
        }
        [Benchmark]
        public int ConvertArray()
        {
            ref CountAction<int> countAction = ref countActions[0];
            countAction.Count = 0;
            convertArray.ForEach(ref countAction);
            return countAction.Count;
        }
    }
}