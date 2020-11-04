using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class SumOnList
    {
        private readonly List<int> list;
        public SumOnList()
        {
            list = Enumerable.Range(-1, 10000).ToList();
        }

        [Benchmark(Baseline = true)]
        public int Linq()
        {
            return list.Sum();
        }

        [Benchmark]
        public int StructLinq()
        {
            return list.ToStructEnumerable().Sum(x => x);
        }

        [Benchmark]
        public int WithVisit()
        {
            var sumVisitor = new SumVisitor(0);
            list.ToStructEnumerable().Visit(ref sumVisitor);
            return sumVisitor.sum;
        }
    }

    public struct SumVisitor : IVisitor<int>
    {
        public int sum;
        public SumVisitor(int sum)
        {
            this.sum = 0;
        }
        public bool Visit(int input)
        {
            sum += input;
            return true;
        }
    }
}