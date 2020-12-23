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
        public List<int> StructLinqZeroAlloc() => array
                                         .ToStructEnumerable()
                                         .Where(x => (x & 1) == 0, x=>x)
                                         .ToList(x=>x);

        
        [Benchmark]
        public List<int> StructLinqWithFunction()
        {
            var where = new WherePredicate();
            return array
                   .ToStructEnumerable()
                   .Where(ref where, x=> x)
                   .ToList(x=> x);
        }
    }
}
