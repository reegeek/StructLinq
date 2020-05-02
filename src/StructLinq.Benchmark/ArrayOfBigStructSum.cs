using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-8750H CPU 2.20GHz(Coffee Lake), 1 CPU, 12 logical and 6 physical cores
    //.NET Core SDK = 3.1.201

    //[Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


    //```
    //|                Method |       Mean |     Error |    StdDev |     Median | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|---------------------- |-----------:|----------:|----------:|-----------:|------:|-------:|------:|------:|----------:|
    //|                ForSum |   560.3 ns |   5.25 ns |   4.10 ns |   559.9 ns |  0.10 |      - |     - |     - |         - |
    //|      SysEnumerableSum | 5,579.8 ns | 104.36 ns |  97.62 ns | 5,538.8 ns |  1.00 |      - |     - |     - |      32 B |
    //|             StructSum | 3,174.1 ns |  31.20 ns |  26.06 ns | 3,168.7 ns |  0.57 | 0.0038 |     - |     - |      24 B |
    //|          RefStructSum | 1,827.7 ns |   3.72 ns |   3.48 ns | 1,827.6 ns |  0.33 | 0.0038 |     - |     - |      24 B |
    //|    ZeroAllocStructSum | 2,180.6 ns |  43.34 ns | 106.31 ns | 2,238.1 ns |  0.36 |      - |     - |     - |         - |
    //| ZeroAllocRefStructSum |   701.0 ns |   3.00 ns |   2.66 ns |   700.5 ns |  0.13 |      - |     - |     - |         - |

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
        public int ForSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += array[i].Element;
            }
            return sum;
        }
        [Benchmark(Baseline = true)]
        public int SysEnumerableSum() => array.Sum(x=> x.Element);

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
                        .Sum(ref @select, x => x, x => x);
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
        public readonly int Eval(StructContainer element)
        {
            return element.Element;
        }
    }

    internal struct InStructContainerSelect : IInFunction<StructContainer, int>
    {
        public readonly int Eval(in StructContainer element)
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