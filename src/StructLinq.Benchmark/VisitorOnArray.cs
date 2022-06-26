using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;


namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48, baseline: true)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [SimpleJob(RuntimeMoniker.Net60)]
    public class VisitorOnArray
    {
        private const int Count = 1_000;
        private readonly int[] array;
        
        public VisitorOnArray()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark]
        public int Sum()
        {
            return array.ToStructEnumerable().Sum(x=>x);
        }

        [Benchmark]
        public int Visitor()
        {
            var visitor = new SumVisitor(0);
            array.ToStructEnumerable().Visit(ref visitor);
            return visitor.sum;
        }

        [Benchmark]
        public int VisitorOnTake()
        {
            var visitor = new SumVisitor(0);
            array.ToStructEnumerable().Take(900, x=>x).Visit(ref visitor);
            return visitor.sum;
        }

        [Benchmark]
        public int VisitorOnSkip()
        {
            var visitor = new SumVisitor(0);
            array.ToStructEnumerable().Skip(100, x=>x).Visit(ref visitor);
            return visitor.sum;
        }

        [Benchmark]
        public int VisitorOnSkipAndTake()
        {
            var visitor = new SumVisitor(0);
            array.ToStructEnumerable().Take(900, x=>x).Skip(100, x => x).Visit(ref visitor);
            return visitor.sum;
        }


        private struct SumVisitor : IVisitor<int>
        {
            public int sum;

            public SumVisitor(int sum)
            {
                this.sum = sum;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(int input)
            {
                sum += input;
                return true;
            }
        }
    }
}