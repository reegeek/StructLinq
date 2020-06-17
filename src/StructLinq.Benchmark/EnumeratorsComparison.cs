using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{

//    ``` ini

//BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
//Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
//.NET Core SDK=3.1.301
//  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
//  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


//```
//|              Method | ItemCount |      Mean |     Error |    StdDev | Ratio | RatioSD | Gen 0 | Gen 1 | Gen 2 | Allocated |
//|-------------------- |---------- |----------:|----------:|----------:|------:|--------:|------:|------:|------:|----------:|
//|          SysForEach |        20 | 0.5446 ns | 0.0052 ns | 0.0046 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |        20 | 0.5995 ns | 0.0049 ns | 0.0041 ns |  1.10 |    0.01 |     - |     - |     - |         - |
//| RefStructEnumerable |        20 | 0.3434 ns | 0.0033 ns | 0.0031 ns |  0.63 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |        20 | 0.8673 ns | 0.0065 ns | 0.0057 ns |  1.59 |    0.02 |     - |     - |     - |         - |
//|                     |           |           |           |           |       |         |       |       |       |           |
//|          SysForEach |       100 | 0.3104 ns | 0.0067 ns | 0.0062 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |       100 | 0.3248 ns | 0.0046 ns | 0.0043 ns |  1.05 |    0.02 |     - |     - |     - |         - |
//| RefStructEnumerable |       100 | 0.5774 ns | 0.0033 ns | 0.0031 ns |  1.86 |    0.04 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |       100 | 0.5699 ns | 0.0026 ns | 0.0022 ns |  1.84 |    0.04 |     - |     - |     - |         - |
//|                     |           |           |           |           |       |         |       |       |       |           |
//|          SysForEach |      1000 | 0.5466 ns | 0.0036 ns | 0.0034 ns |  1.00 |    0.00 |     - |     - |     - |         - |
//|    StructEnumerable |      1000 | 0.3228 ns | 0.0033 ns | 0.0027 ns |  0.59 |    0.01 |     - |     - |     - |         - |
//| RefStructEnumerable |      1000 | 0.5747 ns | 0.0033 ns | 0.0029 ns |  1.05 |    0.01 |     - |     - |     - |         - |
//|   ArrayEnumerableV1 |      1000 | 0.8241 ns | 0.0036 ns | 0.0030 ns |  1.51 |    0.01 |     - |     - |     - |         - |


    [DisassemblyDiagnoser(recursiveDepth: 4), MemoryDiagnoser]
    public class EnumeratorsComparison
    {
        private readonly int[] array;

        [Params(20, 100, 1000)]
        public int ItemCount { get; set; }

        public EnumeratorsComparison()
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
