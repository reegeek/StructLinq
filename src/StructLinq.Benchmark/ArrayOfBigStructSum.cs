using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.301
    //[Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


    //```
    //|                Method |       Mean |    Error |    StdDev |     Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|---------------------- |-----------:|---------:|----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
    //|                ForSum |   610.5 ns |  0.51 ns |   0.48 ns |   610.7 ns |  0.09 |    0.00 |      - |     - |     - |         - |
    //|      SysEnumerableSum | 6,481.6 ns | 14.74 ns |  13.79 ns | 6,475.0 ns |  1.00 |    0.00 | 0.0076 |     - |     - |      32 B |
    //|             StructSum | 3,582.1 ns | 80.46 ns | 162.53 ns | 3,520.8 ns |  0.58 |    0.02 | 0.0076 |     - |     - |      32 B |
    //|          RefStructSum | 1,999.9 ns |  5.37 ns |   5.02 ns | 2,001.4 ns |  0.31 |    0.00 | 0.0076 |     - |     - |      32 B |
    //|    ZeroAllocStructSum | 2,637.2 ns | 52.64 ns | 147.61 ns | 2,725.4 ns |  0.40 |    0.02 |      - |     - |     - |         - |
    //| ZeroAllocRefStructSum |   764.4 ns |  1.30 ns |   1.22 ns |   763.9 ns |  0.12 |    0.00 |      - |     - |     - |         - |
    
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