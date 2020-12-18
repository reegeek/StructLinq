using System;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    [DisassemblyDiagnoser(4), MemoryDiagnoser]
    public class ToArrayOnArraySelect
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ToArrayOnArraySelect()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int[] Linq() => array
                               .Select(x => x * 2)
                               .ToArray();


        [Benchmark]
        public int[] StructLinq() => array
                                     .ToStructEnumerable()
                                     .Select(x => x * 2)
                                     .ToArray();

        [Benchmark]
        public int[] StructLinq2() => array
                                     .ToStructEnumerable()
                                     .Select(x => x * 2)
                                     .ToArray2();

        
        [Benchmark]
        public int[] StructLinqFaster() => array
                                     .ToStructEnumerable()
                                     .Select(x => x * 2)
                                     .ToArray(x=>x);

        [Benchmark]
        public int[] StructLinqFaster2() => array
                                           .ToStructEnumerable()
                                           .Select(x => x * 2)
                                           .ToArray2(x=>x);

        [Benchmark]
        public int[] StructLinqWithFunction()
        {
            var select = new SelectFunction();
            return array
                   .ToStructEnumerable()
                   .Select(ref @select, x=>x, x=>x)
                   .ToArray(x=>x);
        }

        [Benchmark]
        public int[] StructLinqWithFunction2()
        {
            var select = new SelectFunction();
            return array
                   .ToStructEnumerable()
                   .Select(ref @select, x=>x, x=>x)
                   .ToArray2(x=>x);
        }

        [Benchmark]
        public int[] WithVisitor()
        {
            var selectEnumerable = array
                .ToStructEnumerable();
            var visitor = new SelectAndToArrayVisitor<int, int>(array.Length, x=> x * 2);
            selectEnumerable.Visit(ref visitor);
            return visitor.array;
        }
    }

    public struct SelectAndToArrayVisitor<TIn, TOut> : IVisitor<TIn>
    {
        private readonly Func<TIn, TOut> func;
        public TOut[] array;
        private int i;
        public SelectAndToArrayVisitor(int count, Func<TIn, TOut> func)
        {
            this.func = func;
            array = new TOut[count];
            i = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(TIn input)
        {
            array[i++] = func(input);
            return true;
        }
    }
}
