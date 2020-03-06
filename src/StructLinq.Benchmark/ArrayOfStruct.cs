using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;

namespace StructLinq.Benchmark
{

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-8750H CPU 2.20GHz(Coffee Lake), 1 CPU, 12 logical and 6 physical cores
    //.NET Core SDK = 3.1.101

    //[Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


    //```
    //|                Method |      Mean |     Error |    StdDev | Ratio | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|---------------------- |----------:|----------:|----------:|------:|------:|------:|------:|----------:|
    //|  ForEachOnIEnumerable | 38.741 us | 0.0876 us | 0.0731 us |  1.00 |     - |     - |     - |      32 B |
    //|        ForEachOnArray |  3.810 us | 0.0124 us | 0.0116 us |  0.10 |     - |     - |     - |         - |
    //| StructEnumerableArray | 13.976 us | 0.0195 us | 0.0173 us |  0.36 |     - |     - |     - |         - |

    [MemoryDiagnoser]
    public class ArrayOfStruct
    {
        private readonly ArrayEnumerable<int> arrayEnumerable;
        private const int Count = 10000;
        private readonly IEnumerable<int> sysEnumerable;
        private readonly int[] array;
        public ArrayOfStruct()
        {
            array = Enumerable.Range(0, Count).ToArray();
            sysEnumerable = array;
            arrayEnumerable = array.ToStructEnumerable();
        }

        [Benchmark(Baseline = true)]
        public int ForEachOnIEnumerable()
        {
            int sum = 0;
            foreach (var i in sysEnumerable)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnArray()
        {
            int sum = 0;
            foreach (var i in array)
            {
                sum+=i;
            }
            return sum;
        }

        [Benchmark]
        public int StructEnumerableArray()
        {
            var sumAction = new SumIntAction {Sum = 0};
            arrayEnumerable.ForEach(ref sumAction, x=>x);
            return sumAction.Sum;
        }
    }

    public struct SumIntAction : IAction<int>
    {
        public int Sum;
        public void Do(int element)
        {
            Sum += element;
        }
    }
}