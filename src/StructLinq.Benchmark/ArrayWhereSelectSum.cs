using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayWhereSelectSum
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ArrayWhereSelectSum()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }
        [Benchmark(Baseline = true)]
        public int HandmadedCode()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var elt = array[i];
                if ((elt & 1) == 0)
                {
                    var mult = elt * 2;
                    sum += mult;
                }
            }
            return sum;
        }
        [Benchmark]
        public int SysLinq() => array
            .Where(x => (x & 1) == 0)
            .Select(x => x * 2)
            .Sum();

        [Benchmark]
        public int StructRangeWhereSelectSumWithDelegate() => array
            .ToStructEnumerable()
            .Where(x => (x & 1) == 0, x => x)
            .Select(x => x * 2, x => x)
            .Sum();

        [Benchmark]
        public int StructRangeWhereSelectSum()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            return array
                .ToStructEnumerable()
                .Where(ref @where, x => x)
                .Select(ref @select, x => x, x => x)
                .Sum(x => x);
        }
    }
}