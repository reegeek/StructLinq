using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.Select;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArrayReadonlyStructSum
    {
        private readonly IEnumerable<int> sysArray;
        private const int Count = 1000;
        private readonly ReadonlyStructContainer[] array;
        private readonly ITypedEnumerable<int, SelectEnumerator<ReadonlyStructContainer, int, ArrayStructEnumerator<ReadonlyStructContainer>, ReadonlyStructContainerSelect>> safeStructArray;
        private readonly ITypedEnumerable<int, SelectEnumerator<ReadonlyStructContainer, int, ArrayStructEnumerator<ReadonlyStructContainer>, StructFunction<ReadonlyStructContainer, int>>> convertArray;
        public ArrayReadonlyStructSum()
        {
            array = Enumerable.Range(0, Count).Select(x => ReadonlyStructContainer.Create(x)).ToArray();
            var @select = new ReadonlyStructContainerSelect();
            sysArray = array.Select(x => x.Element);
            convertArray = array.ToTypedEnumerable().Select(x => x.Element);
            safeStructArray = array.ToTypedEnumerable().Select(in select, Id<int>.Value);
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

    internal struct ReadonlyStructContainerSelect : IFunction<ReadonlyStructContainer, int>
    {
        public readonly int Eval(in ReadonlyStructContainer element)
        {
            return element.Element;
        }
    }


    internal readonly struct ReadonlyStructContainer
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
        public ReadonlyStructContainer(int element, int element1, int element2, int element3, int element4, int element5, int element6, int element7, int element8)
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
        public static ReadonlyStructContainer Create(int element)
        {
            return new ReadonlyStructContainer(element, element, element, element, element, element, element, element, element);
        }
    }

}