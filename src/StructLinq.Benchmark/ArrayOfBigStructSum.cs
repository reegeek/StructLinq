using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.101
    //[Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


    //```
    //|           Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
    //|           SysSum |   613.5 ns |  2.22 ns |  2.08 ns |  0.09 |      - |     - |     - |         - |
    //| SysEnumerableSum | 6,813.1 ns | 26.47 ns | 23.46 ns |  1.00 | 0.0076 |     - |     - |      48 B |
    //|        StructSum | 3,132.6 ns | 14.93 ns | 13.96 ns |  0.46 |      - |     - |     - |         - |

    [MemoryDiagnoser]
    public class ArrayOfBigStructSum
    {
        private const int Count = 1000;
        private readonly StructContainer[] array;
        public ArrayOfBigStructSum()
        {
            array = Enumerable.Range(0, Count).Select(x => StructContainer.Create(x)).ToArray();
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
        public int SysEnumerableSum() => array.Select(x=> x.Element).Sum();

        [Benchmark]
        public int StructSum()
        {
            var @select = new StructContainerSelect();
            return array.ToStructEnumerable()
                        .Select(ref @select, x=>x, x=>x)
                        .Sum(x=>x);
        }
    }


    internal struct StructContainerSelect : IFunction<StructContainer, int>
    {
        public readonly int Eval(StructContainer element)
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