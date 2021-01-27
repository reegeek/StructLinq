using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayWhereCount
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ArrayWhereCount()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int HandmadedCode()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                var elt = array[i];
                if ((elt & 1) == 0)
                {
                    count++;
                }
            }
            return count;
        }
        
        [Benchmark]
        public int SysLinq() => array
                                .Where(x => (x & 1) == 0)
                                .Count();

        [Benchmark]
        public int StructLinqWithDelegate() => array.ToStructEnumerable()
                                                    .Where(x => (x & 1) == 0)
                                                    .Count();

        [Benchmark]
        public int StructLinqWithDelegateZeoAlloc() => array.ToStructEnumerable()
                                                            .Where(x => (x & 1) == 0, x=> x)
                                                            .Count(x=>x);

        [Benchmark]
        public int StructLinqWithFunction()
        {
            var where = new WherePredicate();
            return array
                   .ToStructEnumerable()
                   .Where(ref @where, x => x)
                   .Count(x => x);
        }
    }
}
