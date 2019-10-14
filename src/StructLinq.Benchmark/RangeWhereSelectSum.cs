using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.IEnumerable;
using StructLinq.Range;
using StructLinq.Select;
using StructLinq.Where;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class RangeWhereSelectSum
    {
        private readonly IEnumerable<int> sysRange;
        private const int Count = 10000;
        private readonly IStructEnumerable<int, SelectEnumerator<int, int, WhereEnumerator<int, GenericEnumerator<int>, StructFunction<int, bool>>, StructFunction<int, int>>> convertWithDelegate;
        private readonly IStructEnumerable<int, SelectEnumerator<int, int, WhereEnumerator<int, RangeEnumerator, WherePredicate>, SelectFunction>> structRange;
        private readonly IStructEnumerable<int, SelectEnumerator<int, int, WhereEnumerator<int, GenericEnumerator<int>, WherePredicate>, SelectFunction>> convertWithStruct;
        public RangeWhereSelectSum()
        {
            sysRange = Enumerable.Range(0, Count)
                .Where(x=> (x & 1)==0)
                .Select(x=> x * 2);
            var where = new WherePredicate();
            var select = new SelectFunction();
            convertWithDelegate = Enumerable.Range(0, Count).ToTypedEnumerable()
                .Where(x => (x & 1) == 0)
                .Select(x => x *2);
            convertWithStruct = Enumerable.Range(0, Count).ToTypedEnumerable()
                .Where(in where)
                .Select(in select, Id<int>.Value);
            structRange = StructEnumerable.Range(0, Count)
                .Where(in where)
                .Select(in select, Id<int>.Value);
        }
        [Benchmark(Baseline = true)]
        public int SysSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                if ((i & 1) == 0)
                {
                    var mult = i * 2;
                    sum += mult;
                }
            }
            return sum;
        }
        [Benchmark]
        public int SysRangeWhereSelectSum() => sysRange.Sum();

        [Benchmark]
        public int ConvertWhereSelectSumWithDelegate() => convertWithDelegate.Sum();

        [Benchmark]
        public int ConvertWhereSelectSumWithStruct() => convertWithStruct.Sum();

        [Benchmark]
        public int StructRangeWhereSelectSum() => structRange.Sum();
    }

    struct WherePredicate : IFunction<int, bool>
    {
        public readonly bool Eval(in int element)
        {
            return (element & 1) == 0;
        }
    }

    struct SelectFunction : IFunction<int, int>
    {
        public readonly int Eval(in int element)
        {
            return element * 2;
        }
    }

}