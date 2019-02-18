using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Range;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ForEach
    {
        private readonly IEnumerable<int> sysRange;
        private readonly ITypedEnumerable<int, RangeEnumerator> structRange;
        private CountAction[] countActions = new CountAction[1];
        public int Count = 10000;
        public ForEach()
        {
            sysRange = Enumerable.Range(0, Count);
            structRange = StructEnumerable.Range(0, Count);
            ref CountAction countAction = ref countActions[0];
        }

        [Benchmark(Baseline = true)]
        public int SysForEach()
        {
            int count = 0;
            foreach (var i in sysRange)
            {
                count++;
            }
            return count;
        }
        [Benchmark]
        public int DelegateForEach()
        {
            int count = 0;
            structRange.ForEach(i => count++);
            return count;
        }

        [Benchmark]
        public int StructForEach()
        {
            ref CountAction countAction = ref countActions[0];
            countAction.Count = 0;
            structRange.ForEach(ref countAction);
            return countAction.Count;
        } 

        struct CountAction : IAction<int>
        {
            public int Count;
            public void Do(int element)
            {
                Count++;
            }
        }

    }
}