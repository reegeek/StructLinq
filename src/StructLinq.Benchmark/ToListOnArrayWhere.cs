using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using StructLinq.BCL.List;
using StructLinq.Utils.Collections;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ToListOnArrayWhere
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ToListOnArrayWhere()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }

        [Benchmark(Baseline = true)]
        public List<int> Linq() => array
                                   .Where(x => (x & 1) == 0)
                                   .ToList();


        [Benchmark]
        public List<int> StructLinq() => array
                                         .ToStructEnumerable()
                                         .Where(x => (x & 1) == 0)
                                         .ToList();

        [Benchmark]
        public List<int> StructLinqFaster()
        {
            var where = new WherePredicate();
            return array
                   .ToStructEnumerable()
                   .Where(ref where, x=> x)
                   .ToList(x=> x);
        }

        [Benchmark]
        public List<int> WithVisit()
        {
            var where = new WherePredicate();
            var visitor = new PooledListVisitor<int>(0, ArrayPool<int>.Shared);
            var whereEnumerable = array
                .ToStructEnumerable()
                .Where(ref @where, x=> x)
                .Visit(ref visitor);
            var resultArray = visitor.PooledList.ToArray();
            visitor.Dispose();
            var result = new List<int>();
            var listLayout = Unsafe.As<List<int>, ListLayout<int>>(ref result);
            listLayout.Items = resultArray;
            listLayout.Size = resultArray.Length;
            return result;

        }
    }
}
