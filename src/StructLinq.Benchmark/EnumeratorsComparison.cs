using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace StructLinq.Benchmark
{

//``` ini

//BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
//Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
//.NET Core SDK=3.1.301
//  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
//  Job-BNPWEC : .NET Framework 4.8 (4.8.4180.0), X64 RyuJIT
//  Job-AOFHFD : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


//```
//|              Method |       Runtime | ItemCount |        Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
//|-------------------- |-------------- |---------- |------------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
//|          SysForEach |      .NET 4.8 |         2 |   0.4405 ns | 0.0043 ns | 0.0040 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      .NET 4.8 |         2 |   2.1837 ns | 0.0527 ns | 0.0493 ns |  4.96 |    0.10 |     - |     - |     - |         - |
//| RefStructEnumerable |      .NET 4.8 |         2 |   2.2161 ns | 0.0229 ns | 0.0215 ns |  5.03 |    0.06 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      .NET 4.8 |         2 |   1.9728 ns | 0.0067 ns | 0.0063 ns |  4.48 |    0.04 |     - |     - |     - |         - |
//|                     |               |           |             |           |           |       |         |       |       |       |           |
//|          SysForEach | .NET Core 3.1 |         2 |   0.5396 ns | 0.0016 ns | 0.0015 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable | .NET Core 3.1 |         2 |   2.1865 ns | 0.0653 ns | 0.0611 ns |  4.05 |    0.11 |     - |     - |     - |         - |
//| RefStructEnumerable | .NET Core 3.1 |         2 |   2.2082 ns | 0.0444 ns | 0.0415 ns |  4.09 |    0.08 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 | .NET Core 3.1 |         2 |   2.1915 ns | 0.0052 ns | 0.0049 ns |  4.06 |    0.02 |     - |     - |     - |         - |
//|                     |               |           |             |           |           |       |         |       |       |       |           |
//|          SysForEach |      .NET 4.8 |        20 |   7.3500 ns | 0.0521 ns | 0.0435 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      .NET 4.8 |        20 |  12.0457 ns | 0.0289 ns | 0.0257 ns |  1.64 |    0.01 |     - |     - |     - |         - |
//| RefStructEnumerable |      .NET 4.8 |        20 |  12.0329 ns | 0.0151 ns | 0.0141 ns |  1.64 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      .NET 4.8 |        20 |  11.7895 ns | 0.0223 ns | 0.0186 ns |  1.60 |    0.01 |     - |     - |     - |         - |
//|                     |               |           |             |           |           |       |         |       |       |       |           |
//|          SysForEach | .NET Core 3.1 |        20 |   6.4606 ns | 0.0357 ns | 0.0316 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable | .NET Core 3.1 |        20 |  12.0096 ns | 0.0167 ns | 0.0156 ns |  1.86 |    0.01 |     - |     - |     - |         - |
//| RefStructEnumerable | .NET Core 3.1 |        20 |  12.0109 ns | 0.0177 ns | 0.0166 ns |  1.86 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 | .NET Core 3.1 |        20 |  12.1919 ns | 0.0560 ns | 0.0468 ns |  1.89 |    0.01 |     - |     - |     - |         - |
//|                     |               |           |             |           |           |       |         |       |       |       |           |
//|          SysForEach |      .NET 4.8 |       100 |  48.3473 ns | 0.0792 ns | 0.0702 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      .NET 4.8 |       100 |  62.4214 ns | 0.1354 ns | 0.1201 ns |  1.29 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable |      .NET 4.8 |       100 |  62.4069 ns | 0.0673 ns | 0.0596 ns |  1.29 |    0.00 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      .NET 4.8 |       100 |  68.5396 ns | 0.1144 ns | 0.1070 ns |  1.42 |    0.00 |     - |     - |     - |         - |
//|                     |               |           |             |           |           |       |         |       |       |       |           |
//|          SysForEach | .NET Core 3.1 |       100 |  45.8706 ns | 0.0897 ns | 0.0839 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable | .NET Core 3.1 |       100 |  62.3429 ns | 0.0346 ns | 0.0324 ns |  1.36 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable | .NET Core 3.1 |       100 |  62.3556 ns | 0.0597 ns | 0.0529 ns |  1.36 |    0.00 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 | .NET Core 3.1 |       100 |  70.0020 ns | 0.1444 ns | 0.1280 ns |  1.53 |    0.00 |     - |     - |     - |         - |
//|                     |               |           |             |           |           |       |         |       |       |       |           |
//|          SysForEach |      .NET 4.8 |      1000 | 417.3332 ns | 0.3485 ns | 0.2910 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      .NET 4.8 |      1000 | 567.4289 ns | 0.6140 ns | 0.5744 ns |  1.36 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable |      .NET 4.8 |      1000 | 567.2359 ns | 0.5251 ns | 0.4912 ns |  1.36 |    0.00 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      .NET 4.8 |      1000 | 623.8758 ns | 0.6485 ns | 0.5749 ns |  1.49 |    0.00 |     - |     - |     - |         - |
//|                     |               |           |             |           |           |       |         |       |       |       |           |
//|          SysForEach | .NET Core 3.1 |      1000 | 415.8917 ns | 0.4108 ns | 0.3843 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable | .NET Core 3.1 |      1000 | 567.3921 ns | 0.6553 ns | 0.6130 ns |  1.36 |    0.00 |     - |     - |     - |         - |
//| RefStructEnumerable | .NET Core 3.1 |      1000 | 567.2166 ns | 0.7208 ns | 0.6742 ns |  1.36 |    0.00 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 | .NET Core 3.1 |      1000 | 629.9132 ns | 1.3090 ns | 1.2244 ns |  1.51 |    0.00 |     - |     - |     - |         - |



    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class EnumeratorsComparison
    {
        private int[] array;

        [Params(2, 20, 100, 1000)]
        public int ItemCount { get; set; }
        
        [GlobalSetup]
        public void GlobalSetup()
        {
            array = Enumerable.Range(0, ItemCount).ToArray();
        }

        [Benchmark(Baseline = true)]
        public int SysForEach()
        {
            var sum = 0;
            foreach (var i in array)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToStructEnumerable())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int RefStructEnumerable()
        {
            var sum = 0;
            foreach (var i in array.ToRefStructEnumerable())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int ArrayEnumerableV1()
        {
            var sum = 0;
            var arrayEnumerableV1 = new ArrayEnumerableV1<int>(array);
            foreach (var i in arrayEnumerableV1)
            {
                sum += i;
            }

            return sum;
        }

    }

    public struct ArrayEnumerableV1<T>
    {
        private readonly T[] array;

        public ArrayEnumerableV1(T[] array)
        {
            this.array = array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Enumerator GetEnumerator()
        {
            return new Enumerator(array);
        }

        public struct Enumerator
        {
            private readonly T[] items;
            private readonly int size;
            private int _nextIndex;

            internal Enumerator(T[] array)
            {
                items = array;
                size = array.Length;
                _nextIndex = 0;
            }

            public bool MoveNext()
            {
                if ((uint)_nextIndex < (uint)size)
                {
                    ++_nextIndex;
                    return true;
                }

                return false;
            }

            public T Current => items[_nextIndex - 1];

            public void Reset() => _nextIndex = 0;
        }
    }



}
