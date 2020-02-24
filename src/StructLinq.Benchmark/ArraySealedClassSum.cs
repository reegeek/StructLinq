using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.IEnumerable;
using StructLinq.Select;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class ArraySealedClassSum
    {
        private readonly IEnumerable<int> sysArray;
        private const int Count = 1000;
        private readonly SealedContainer[] array;
        private SelectEnumerable<SealedContainer, int, RefArrayStructEnumerator<SealedContainer>, SealedContainerSelect> safeStructArray;
        private readonly SelectEnumerable<SealedContainer, int, RefArrayStructEnumerator<SealedContainer>, StructFunction<SealedContainer, int>> convertArray;
        public ArraySealedClassSum()
        {
            array = Enumerable.Range(0, Count).Select(x=> new SealedContainer(x)).ToArray();
            var @select = new SealedContainerSelect();
            sysArray = array.Select(x=> x.Element);
            convertArray = array.ToRefTypedEnumerable().Select(x => x.Element);
            safeStructArray = array.ToRefTypedEnumerable().Select(in select, Id<int>.Value);
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
        public int SafeStructSum() => safeStructArray.Sum(x=> x);
    }

    internal struct SealedContainerSelect : IFunction<SealedContainer, int>
    {
        public readonly int Eval(in SealedContainer element)
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