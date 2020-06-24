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
    //|           Method |       Mean |   Error |  StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------- |-----------:|--------:|--------:|------:|-------:|------:|------:|----------:|
    //|           SysSum |   511.5 ns | 1.09 ns | 1.02 ns |  0.09 |      - |     - |     - |         - |
    //| SysEnumerableSum | 5,742.4 ns | 9.98 ns | 9.33 ns |  1.00 | 0.0076 |     - |     - |      48 B |
    //|        StructSum | 1,732.9 ns | 0.41 ns | 0.34 ns |  0.30 |      - |     - |     - |         - |
    
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


    internal class Container
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