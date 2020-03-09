using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.IEnumerable;
using StructLinq.Range;

namespace StructLinq.Benchmark
{

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.101
    //[Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


    //```
    //|     Method |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
    //|     ForSum |  3.116 us | 0.0663 us | 0.1161 us |  1.00 |    0.00 |     - |     - |     - |         - |
    //|     SysSum | 45.478 us | 0.9326 us | 1.3375 us | 14.52 |    0.73 |     - |     - |     - |      40 B |
    //|  StructSum |  3.044 us | 0.0597 us | 0.0687 us |  0.98 |    0.04 |     - |     - |     - |         - |
    //| ConvertSum | 44.414 us | 0.6786 us | 0.6348 us | 14.17 |    0.67 |     - |     - |     - |      41 B |


    [MemoryDiagnoser, DisassemblyDiagnoser(recursiveDepth: 4)]
    public class Sum
    {
        private readonly IEnumerable<int> sysRange;
        private readonly IStructEnumerable<int, GenericEnumerator<int>> convertRange;
        private const int Count = 10000;
        private readonly IStructEnumerable<int, RangeEnumerator> structRange;
        public Sum()
        {
            sysRange = Enumerable.Range(0, Count);
            convertRange = Enumerable.Range(0, Count).ToStructEnumerable();
            structRange = StructEnumerable.Range(0, Count);
        }


        [Benchmark(Baseline = true)]
        public int ForSum()
        {
            int sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int SysSum()
        {
            return sysRange.Sum();
        }

        [Benchmark]
        public int StructSum()
        {
            return structRange.Sum();
        }

        [Benchmark]
        public int ConvertSum()
        {
            return convertRange.Sum();
        }

    }
}