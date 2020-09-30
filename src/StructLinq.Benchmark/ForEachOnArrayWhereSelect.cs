using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
   
    [MemoryDiagnoser]
    public class ForEachOnArrayWhereSelect
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ForEachOnArrayWhereSelect()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }


        [Benchmark]
        public int SysLinq()
        {
            var enumerable = array
                             .Where(x => (x & 1) == 0)
                             .Select(x => x * 2);
            var sum = 0;
            foreach (var i in enumerable)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqWithDelegate()
        {
            var enumerable = array
                             .ToStructEnumerable()
                             .Where(x => (x & 1) == 0, x => x)
                             .Select(x => x * 2, x => x);
            var sum = 0;
            foreach (var i in enumerable)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqWithDelegateAsEnumerable()
        {
            var enumerable = array
                             .ToStructEnumerable()
                             .Where(x => (x & 1) == 0, x => x)
                             .Select(x => x * 2, x => x);

            var sum = 0;
            foreach (var i in enumerable.ToEnumerable())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            var enumerable = array
                             .ToStructEnumerable()
                             .Where(ref @where, x => x)
                             .Select(ref @select, x => x, x => x);

            var sum = 0;
            foreach (var i in enumerable)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqAsEnumerable()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            var enumerable = array
                             .ToStructEnumerable()
                             .Where(ref @where, x => x)
                             .Select(ref @select, x => x, x => x);

            var sum = 0;
            foreach (var i in enumerable.ToEnumerable())
            {
                sum += i;
            }

            return sum;
        }

    }
}
