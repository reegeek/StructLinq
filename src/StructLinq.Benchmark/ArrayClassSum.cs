using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.Select;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayClassSum
    {
        private readonly IEnumerable<int> sysArray;
        public int Count = 1000;
        private readonly Container[] array;
        private readonly ITypedEnumerable<int, SelectEnumerator<Container, int, ArrayStructEnumerator<Container>, Select>> safeStructArray;
        private ITypedEnumerable<int, SelectEnumerator<Container, int, ArrayStructEnumerator<Container>, StructFunction<Container, int>>> convertArray;
        private Select select;
        public ArrayClassSum()
        {
            array = Enumerable.Range(0, Count).Select(x=> new Container(x)).ToArray();
            select = new Select();
            sysArray = array.Select(x=> x.Element);
            convertArray = array.ToTypedEnumerable().Select(x => x.Element);
            safeStructArray = array.ToTypedEnumerable().Select(ref select, Identity<int>.Instance);
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
        public int SysEnumerableSum() => sysArray.Sum();

        [Benchmark]
        public int ConvertSum() => convertArray.Sum();

        [Benchmark]
        public int SafeStructSum() => safeStructArray.Sum();

        private sealed class Container
        {
            public readonly int Element;
            public Container(int element)
            {
                Element = element;
            }
        }
        private struct Select : IFunction<Container, int>
        {
            public int Eval(Container element)
            {
                return element.Element;
            }
        }
    }
}