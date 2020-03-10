using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.Select;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArraySealedClassSum
    {
        private readonly IEnumerable<int> sysArray;
        private const int Count = 1000;
        private readonly SealedContainer[] array;
        private readonly IStructEnumerable<int, SelectEnumerator<SealedContainer, int, ArrayStructEnumerator<SealedContainer>, SealedContainerSelect>> safeStructArray;
        private readonly IStructEnumerable<int, SelectEnumerator<SealedContainer, int, ArrayStructEnumerator<SealedContainer>, StructFunction<SealedContainer, int>>> convertArray;
        public ArraySealedClassSum()
        {
            array = Enumerable.Range(0, Count).Select(x=> new SealedContainer(x)).ToArray();
            var @select = new SealedContainerSelect();
            sysArray = array.Select(x=> x.Element);
            convertArray = array.ToStructEnumerable().Select(x => x.Element, x => x);
            safeStructArray = array.ToStructEnumerable().Select(ref select, x=>x, x => x);
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

    internal struct SealedContainerSelect : IFunction<SealedContainer, int>
    {
        public readonly int Eval(SealedContainer element)
        {
            return element.Element;
        }
    }


    internal sealed class SealedContainer
    {
        public readonly int Element;
        public SealedContainer(int element)
        {
            Element = element;
        }
    }

}