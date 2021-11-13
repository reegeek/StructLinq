using System;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class VisitorComparison
    {
        private readonly int Count = 500;
        private readonly int[] array;
        
        public VisitorComparison()
        {
            array = Enumerable.ToArray(Enumerable.Range(0, Count));
        }

        [Benchmark(Baseline = true)]
        public int Foreach()
        {
            int sum = 0;
            var enumerable = array;
            foreach (var i in enumerable)
            {
                sum += enumerable[i];
            }
            return sum;
        }

        [Benchmark]
        public int SumV1() => array.ToStructEnumerable().SumV1(x=>x);

        [Benchmark]
        public int SumV2() => array.ToStructEnumerable().SumV2();

        [Benchmark]
        public int SumV3() => array.ToStructEnumerable().SumV3(x=>x);

        [Benchmark]
        public int SumV4() => array.ToStructEnumerable().SumV4();

        [Benchmark]
        public int SumV5() => array.ToStructEnumerable().SumV5(x=>x);

        [Benchmark]
        public int SumV6() => array.ToStructEnumerable().SumV6();
    }

    static class SumExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int SumEnumerator<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<int>
        {
            var visitor = new SumVisitor(0);
            enumerator.Visit(ref visitor);
            enumerator.Dispose();
            return visitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int SumEnumerator<TEnumerator, TVisitor>(this TEnumerator enumerator, TVisitor visitor)
            where TEnumerator : struct, IStructEnumerator<int>
            where TVisitor : struct, ISumVisitor<int>
        {
            enumerator.Visit(ref visitor);
            enumerator.Dispose();
            return visitor.Sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumV1<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<int, TEnumerator>> _) 
            where TEnumerator : struct, IStructEnumerator<int>
            where TEnumerable : IStructEnumerable<int, TEnumerator>
        {
            var visitor = new SumVisitor(0);
            var enumerator = enumerable.GetEnumerator();
            enumerator.Visit(ref visitor);
            enumerator.Dispose();
            return visitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumV2<TEnumerator>(this IStructEnumerable<int, TEnumerator> enumerable) 
            where TEnumerator : struct, IStructEnumerator<int>
        {
            var visitor = new SumVisitor(0);
            var enumerator = enumerable.GetEnumerator();
            enumerator.Visit(ref visitor);
            enumerator.Dispose();
            return visitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumV3<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<int, TEnumerator>> _) 
            where TEnumerator : struct, IStructEnumerator<int>
            where TEnumerable : IStructEnumerable<int, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumEnumerator(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumV4<TEnumerator>(this IStructEnumerable<int, TEnumerator> enumerable) 
            where TEnumerator : struct, IStructEnumerator<int>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumEnumerator(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumV5<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<int, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<int>
            where TEnumerable : IStructEnumerable<int, TEnumerator>
        {
            var visitor = new SumV2Visitor(0);
            return enumerable.GetEnumerator().SumEnumerator(visitor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumV6<TEnumerator>(this IStructEnumerable<int, TEnumerator> enumerable) 
            where TEnumerator : struct, IStructEnumerator<int>
        {
            var visitor = new SumV2Visitor(0);
            return enumerable.GetEnumerator().SumEnumerator(visitor);
        }

        private interface ISumVisitor<T> : IVisitor<T>
        {
            T Sum { get; }
        }

        private struct SumVisitor : IVisitor<int>
        {
            public int sum;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        private struct SumV2Visitor : ISumVisitor<int>
        {
            public int Sum { get; private set; }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public SumV2Visitor(int sum)
            {
                Sum = sum;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(int input)
            {
                Sum += input;
                return true;
            }
        }

    }

}