using System;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser]
    public class ForEach
    {
        private int count;
        private Action<int> action;
        private const int Count = 100000;

        public ForEach()
        {
            count = 0;
            action = i => count++;

        }

        [Benchmark(Baseline = true)]
        public int ClrForEach()
        {
            var sysRange = Enumerable.Range(0, Count);
            foreach (var i in sysRange)
            {
                count++;
            }
            return count;
        }
        [Benchmark]
        public int WithAction()
        {
            StructEnumerable.Range(0, Count).ForEach(action);
            return count;
        }

        [Benchmark]
        public int WithStruct()
        {
            CountAction<int> countAction = new CountAction<int> { Count = 0 };
            StructEnumerable.Range(0, Count).ForEach(ref countAction);
            return countAction.Count;
        }

        [Benchmark]
        public int ZeroAllocWithStruct()
        {
            CountAction<int> countAction = new CountAction<int> { Count = 0 };
            StructEnumerable.Range(0, Count).ForEach(ref countAction, x=> x);
            return countAction.Count;
        }


        [Benchmark]
        public int ToTypedEnumerableWithStruct()
        {
            CountAction<int> countAction = new CountAction<int> { Count = 0 };
            var convertRange = Enumerable.Range(0, Count).ToStructEnumerable();
            convertRange.ForEach(ref countAction);
            return countAction.Count;
        }
    }

    struct CountAction<T> : IAction<T>
    {
        public int Count;
        public void  Do(T element)
        {
            Count++;
        }
    }
}