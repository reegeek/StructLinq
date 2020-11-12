using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace StructLinq.Benchmark
{

    [DisassemblyDiagnoser( 4), MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class EnumeratorsOfClassComparison
    {
        private Container[] array;

        [Params(2, 20, 100, 1000)]
        public int ItemCount { get; set; }
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            array = Enumerable.Range(0, ItemCount).Select(x=> new Container(x)).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int SysForEach()
        {
            var sum = 0;
            foreach (var i in array)
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int StructEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable())
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int RefStructEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToRefStructEnumerable())
            {
                sum += i.Element;
            }

            return sum;
        }

        [Benchmark]
        public int ArrayEnumerableV1()
        {
            var sum = 0;
            var arrayEnumerableV1 = new ArrayEnumerableV1<Container>(array);
            foreach (var i in arrayEnumerableV1)
            {
                sum += i.Element;
            }

            return sum;
        }

    }
}
