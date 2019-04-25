using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.IEnumerable;
using StructLinq.Range;
using StructLinq.Where;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Where
    {
        private readonly IEnumerable<int> sysRange;
        private readonly ITypedEnumerable<int, WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>>
            delegateRange;
        private readonly ITypedEnumerable<int, WhereEnumerator<int, GenericEnumerator<int>, StructFunction<int, bool>>>
            convertRange;
        private CountAction<int>[] countActions = new CountAction<int>[1];
        public int Count = 10000;
        private ITypedEnumerable<int, WhereEnumerator<int, RangeEnumerator, WhereFunc>> structRange;
        public Where()
        {
            sysRange = Enumerable.Range(0, Count).Where(x => x > 0);
            delegateRange = StructEnumerable.Range(0, Count).Where(x => x > 0);
            convertRange = Enumerable.Range(0, Count).ToTypedEnumerable().Where(x => x > 0);
            var predicate = new WhereFunc();
            structRange = StructEnumerable.Range(0, Count).Where(ref predicate);
        }

        [Benchmark(Baseline = true)]
        public int SysSelect()
        {
            int count = 0;
            foreach (var i in sysRange)
            {
                count++;
            }

            return count;
        }

        [Benchmark]
        public int DelegateSelect()
        {
            int count = 0;
            delegateRange.ForEach(i => count++);
            return count;
        }

        [Benchmark]
        public int StructSelect()
        {
            ref CountAction<int> countAction = ref countActions[0];
            countAction.Count = 0;
            structRange.ForEach(ref countAction);
            return countAction.Count;
        }

        [Benchmark]
        public int ConvertSelect()
        {
            ref CountAction<int> countAction = ref countActions[0];
            countAction.Count = 0;
            convertRange.ForEach(ref countAction);
            return countAction.Count;
        }
    }

    struct WhereFunc : IFunction<int, bool>
    {
        public bool Eval(in int element)
        {
            return element > 0;
        }
    }
}

    