using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace StructLinq.Benchmark
{

    [DisassemblyDiagnoser( 4), MemoryDiagnoser]
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
