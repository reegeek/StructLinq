using System;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-8750H CPU 2.20GHz(Coffee Lake), 1 CPU, 12 logical and 6 physical cores
    //.NET Core SDK = 3.1.101

    //[Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


    //```
    //|                      Method |     Mean |   Error |  StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|---------------------------- |---------:|--------:|--------:|------:|------:|------:|------:|----------:|
    //|                  ClrForEach | 385.1 us | 1.23 us | 1.15 us |  1.00 |     - |     - |     - |      41 B |
    //|                  WithAction | 237.9 us | 0.85 us | 0.79 us |  0.62 |     - |     - |     - |      25 B |
    //|                  WithStruct | 142.2 us | 0.29 us | 0.27 us |  0.37 |     - |     - |     - |      24 B |
    //|         ZeroAllocWithStruct | 139.9 us | 0.41 us | 0.38 us |  0.36 |     - |     - |     - |         - |
    //| ToTypedEnumerableWithStruct | 384.6 us | 0.93 us | 0.82 us |  1.00 |     - |     - |     - |      66 B |

    [MemoryDiagnoser]
    public class ForEach
    {
        private int count;
        private Action<int> action;
        private const int Count = 100000;

        public ForEach()
        {
            count = 0;
            action = i => count++;

        }

        [Benchmark(Baseline = true)]
        public int ClrForEach()
        {
            var sysRange = Enumerable.Range(0, Count);
            foreach (var i in sysRange)
            {
                count++;
            }
            return count;
        }
        [Benchmark]
        public int WithAction()
        {
            StructEnumerable.Range(0, Count).ForEach(action);
            return count;
        }

        [Benchmark]
        public int WithStruct()
        {
            CountAction<int> countAction = new CountAction<int> { Count = 0 };
            StructEnumerable.Range(0, Count).ForEach(ref countAction);
            return countAction.Count;
        }

        [Benchmark]
        public int ZeroAllocWithStruct()
        {
            CountAction<int> countAction = new CountAction<int> { Count = 0 };
            StructEnumerable.Range(0, Count).ForEach(ref countAction, x=> x);
            return countAction.Count;
        }


        [Benchmark]
        public int ToTypedEnumerableWithStruct()
        {
            CountAction<int> countAction = new CountAction<int> { Count = 0 };
            var convertRange = Enumerable.Range(0, Count).ToTypedEnumerable();
            convertRange.ForEach(ref countAction);
            return countAction.Count;
        }
    }

    struct CountAction<T> : IAction<T>
    {
        public int Count;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void  Do(T element)
        {
            Count++;
        }
    }
}