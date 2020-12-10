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
        public int[] StructLinqFaster()
        {
            var select = new SelectFunction();
            return array
                   .ToStructEnumerable()
                   .Select(ref @select, x=>x, x=>x)
                   .ToArray(x=>x);
        }

        [Benchmark]
        public int[] WithVisitor()
        {
            var select = new SelectFunction();
            var selectEnumerable = array
                .ToStructEnumerable()
                .Select(ref @select, x=>x, x=>x);
            var visitor = new ToArrayVisitor<int>(array.Length);
            selectEnumerable.Visit(ref visitor);
            return visitor.array;
        }
    }

    public struct ToArrayVisitor<T> : IVisitor<T>
    {
        public T[] array;
        private int i;
        public ToArrayVisitor(int count)
        {
            array = new T[count];
            i = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Visit(T input)
        {
            array[i++] = input;
            return true;
        }
    }
}
