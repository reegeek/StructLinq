using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    [MemoryDiagnoser]
    public class ForEachOnListOfString
    {
        private readonly List<string> list;
        public ForEachOnListOfString()
        {
            list = Enumerable.Range(-1, 10000).Select(x=> x.ToString()).ToList();
        }

        [Benchmark(Baseline = true)]
        public int Default()
        {
            var sum = 0;
            foreach (var i in list)
            {
                sum += i.Length;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var sum = 0;
            foreach (var i in list.ToStructEnumerable())
            {
                sum += i.Length;
            }
            return sum;
        }

    }
}
