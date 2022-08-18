using System;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
  
    [MemoryDiagnoser]
    public class ArrayOfBigStructSum
    {
        private const int Count = 1000;
        private readonly StructContainer[] array;
        public ArrayOfBigStructSum()
        {
            array = Enumerable.Range(0, Count).Select(StructContainer.Create).ToArray();
        }
        [Benchmark]
        public int Handmaded()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += array[i].Element;
            }
            return sum;
        }
        [Benchmark(Baseline = true)]
        public int SysEnumerableSum()
        {
            return array.Sum(x => x.Element);
        }

        [Benchmark]
        public int StructSum()
        {
            return array.ToStructEnumerable()
                .Sum(x=> x.Element);
        }

        [Benchmark]
        public int RefStructSum()
        {
            return array.ToRefStructEnumerable()
                .Sum((in StructContainer element) => element.Element);
        }

        [Benchmark]
        public int ZeroAllocStructSum()
        {
            var @select = new StructContainerSelect();
            return array.ToStructEnumerable()
                        .Sum(ref @select, x => x);
        }

        [Benchmark]
        public int ZeroAllocRefStructSum()
        {
            var @select = new InStructContainerSelect();
            return array.ToRefStructEnumerable()
                .Sum(ref @select, x => x, x => x);
        }

    }


    internal struct StructContainerSelect : IFunction<StructContainer, int>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Eval(StructContainer element)
        {
            return element.Element;
        }
    }

    internal struct InStructContainerSelect : IInFunction<StructContainer, int>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Eval(in StructContainer element)
        {
            return element.Element;
        }
    }


    internal struct StructContainer : IEquatable<StructContainer>
    {
        public readonly int Element;

        public bool Equals(StructContainer other)
        {
            return Element == other.Element;
        }

        public override bool Equals(object obj)
        {
            return obj is StructContainer other && Equals(other);
        }

        public override int GetHashCode()
        {
            return Element;
        }

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
            return new(element, element, element, element, element, element, element, element, element);
        }
    }


}