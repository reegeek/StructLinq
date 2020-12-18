using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class RangeWhereSelectSum
    {
        private const int Count = 10000;
        public RangeWhereSelectSum()
        {
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
        public int SysRangeWhereSelectSum() => Enumerable.Range(0, Count)
                                                         .Where(x=> (x & 1)==0)
                                                         .Select(x=> x * 2)
                                                         .Sum();

        [Benchmark]
        public int ConvertWhereSelectSumWithDelegate() => Enumerable.Range(0, Count)
                                                                    .ToStructEnumerable()
                                                                    .Where(x => (x & 1) == 0, x=>x)
                                                                    .Select(x => x *2, x => x)
                                                                    .Sum(x=>x);

        [Benchmark]
        public int StructRangeWhereSelectSum()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            return StructEnumerable.Range(0, Count)
                                   .Where(ref @where, x => x)
                                   .Select(ref @select, x => x, x => x)
                                   .Sum(x=>x);
        }
    }

    struct WherePredicate : IFunction<int, bool>
    {
        public readonly bool Eval(int element)
        {
            return (element & 1) == 0;
        }
    }

    struct SelectFunction : IFunction<int, int>
    {
        public readonly int Eval(int element)
        {
            return element * 2;
        }
    }
}