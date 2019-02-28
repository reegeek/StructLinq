using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.IEnumerable;
using StructLinq.Range;
using StructLinq.Select;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Select
    {
        private readonly IEnumerable<double> sysRange;
        private readonly ITypedEnumerable<double, SelectEnumerator<int, double, RangeEnumerator, StructFunction<int, double>>> delegateRange;
        private readonly ITypedEnumerable<double, SelectEnumerator<int, double, GenericEnumerator<int>, StructFunction<int, double>>> convertRange;
        private CountAction<double>[] countActions = new CountAction<double>[1];
        public int Count = 10000;
        private ITypedEnumerable<double, SelectEnumerator<int, double, RangeEnumerator, MultFunction>> structRange;
        public Select()
        {
            sysRange = Enumerable.Range(0, Count).Select(x=> x * 2.0);
            delegateRange = StructEnumerable.Range(0, Count).Select(x=> x * 2.0);
            convertRange = Enumerable.Range(0, Count).ToTypedEnumerable().Select(x=> x * 2.0);
            var multFunction = new MultFunction();
            structRange = StructEnumerable.Range(0, Count).Select(ref multFunction, Identity<double>.Instance);
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
            ref CountAction<double> countAction = ref countActions[0];
            countAction.Count = 0;
            structRange.ForEach(ref countAction);
            return countAction.Count;
        }

        [Benchmark]
        public int ConvertSelect()
        {
            ref CountAction<double> countAction = ref countActions[0];
            countAction.Count = 0;
            convertRange.ForEach(ref countAction);
            return countAction.Count;
        }
    }

    struct MultFunction : IFunction<int, double>
    {
        public double Eval(int element)
        {
            return element * 2.0;
        }
    }

}