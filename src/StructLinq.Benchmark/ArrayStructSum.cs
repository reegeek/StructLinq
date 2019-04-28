using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.Select;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayStructSum
    {
        private readonly IEnumerable<int> sysArray;
        public int Count = 1000;
        private readonly StructContainer[] array;
        private readonly ITypedEnumerable<int, SelectEnumerator<StructContainer, int, ArrayStructEnumerator<StructContainer>, StructContainerSelect>> safeStructArray;
        private ITypedEnumerable<int, SelectEnumerator<StructContainer, int, ArrayStructEnumerator<StructContainer>, StructFunction<StructContainer, int>>> convertArray;
        private StructContainerSelect select;
        public ArrayStructSum()
        {
            array = Enumerable.Range(0, Count).Select(x => StructContainer.Create(x)).ToArray();
            select = new StructContainerSelect();
            sysArray = array.Select(x => x.Element);
            convertArray = array.ToTypedEnumerable().Select(x => x.Element);
            safeStructArray = array.ToTypedEnumerable().Select(ref select, Id<int>.Value);
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
    }


    internal struct StructContainerSelect : IFunction<StructContainer, int>
    {
        public int Eval(in StructContainer element)
        {
            return element.Element;
        }
    }


    internal struct StructContainer
    {
        public readonly int Element;
        public readonly int Element1;
        public readonly int Element2;
        public readonly int Element3;
        public readonly int Element4;
        public readonly int Element5;
        public readonly int Element6;
        public readonly int Element7;
        public readonly int Element8;
        public StructContainer(int element, int element1, int element2, int element3, int element4, int element5, int element6, int element7, int element8)
        {
            Element = element;
            Element1 = element1;
            Element2 = element2;
            Element3 = element3;
            Element4 = element4;
            Element5 = element5;
            Element6 = element6;
            Element7 = element7;
            Element8 = element8;
        }
        public static StructContainer Create(int element)
        {
            return new StructContainer(element, element, element, element, element, element, element, element, element);
        }
    }


}