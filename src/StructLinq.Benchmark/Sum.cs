using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Sum
    {
        private const int Count = 10000;
        public Sum()
        {
        }


        [Benchmark(Baseline = true)]
        public int ForSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int SysSum()
        {
            return Enumerable.Range(0, Count).Sum();
        }

        [Benchmark]
        public int StructSum()
        {
            return StructEnumerable.Range(0, Count).Sum(x=>x);
        }

        [Benchmark]
        public int StructForEachSum()
        {
            var sum = 0;
            foreach (var i in StructEnumerable.Range(0, Count))
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ConvertSum()
        {
            return Enumerable.Range(0, Count).ToStructEnumerable().Sum(x=>x);
        }

        [Benchmark]
        public int WithVisitor()
        {
            var visitor = new SumVisitor(0);
            StructEnumerable.Range(0, Count)
                .Visit(ref visitor);
            return visitor.sum;
        }

    }

    public struct IntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x - y;
        }
    }
}