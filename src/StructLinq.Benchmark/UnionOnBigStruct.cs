using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class UnionOnBigStruct
    {
        private const int Count = 10000;
        private StructContainer[] array1;
        private StructContainer[] array2;

        public UnionOnBigStruct()
        {
            var size1 = Count / 2;
            var size2 = Count - size1;
            array1 = Enumerable.Range(0, size1).Select(StructContainer.Create).ToArray();
            array2 = Enumerable.Range(size1 - 100, size2).Select(StructContainer.Create).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            var sum = 0;
            foreach (var i in array1.Union(array2))
            {
                sum += i.Element;
            }
            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in array1.ToStructEnumerable().Union(array2.ToStructEnumerable(), x=> x, x=>x))
            {
                sum += i.Element;
            }
            return sum;
        }

        [Benchmark]
        public int RefStructLinq()
        {
            var sum = 0;
            foreach (var i in array1.ToRefStructEnumerable().Union(array2.ToRefStructEnumerable(), x=> x, x=>x))
            {
                sum += i.Element;
            }
            return sum;
        }


        [Benchmark]
        public int RefStructLinqWithComparer()
        {
            var sum = 0;
            var comparer = new DistinctOnBigStruct.StructEqualityComparer();
            foreach (var i in array1.ToRefStructEnumerable().Union(array2.ToRefStructEnumerable(), comparer, x=> x, x=>x))
            {
                sum += i.Element;
            }
            return sum;
        }

    }
}
