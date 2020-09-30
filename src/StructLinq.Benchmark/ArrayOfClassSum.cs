using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
   
    [MemoryDiagnoser]
    public class ArrayOfClassSum
    {
        private const int Count = 1000;
        private readonly Container[] array;
        public ArrayOfClassSum()
        {
            array = Enumerable.Range(0, Count).Select(x => new Container(x)).ToArray();
        }
        [Benchmark]
        public int SysSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += array[i].Element;
            }
            return sum;
        }
        [Benchmark(Baseline = true)]
        public int SysEnumerableSum() => array.Select(x => x.Element).Sum();

        [Benchmark]
        public int StructSum()
        {
            var @select = new ContainerSelect();
            return array.ToStructEnumerable()
                        .Select(ref @select, x=>x, x=>x)
                        .Sum(x => x);
        }
    }


    public class Container
    {
        public readonly int Element;
        public Container(int element)
        {
            Element = element;
        }
    }


    internal struct ContainerSelect : IFunction<Container, int>
    {
        public readonly int Eval(Container element)
        {
            return element.Element;
        }
    }

}