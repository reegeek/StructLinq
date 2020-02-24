using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.Array;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    public class ArrayOfClass
    {
        private readonly RefArrayEnumerable<Class> arrayEnumerable;
        private const int Count = 10000;
        private readonly IEnumerable<Class> sysEnumerable;
        private readonly Class[] array;
        public ArrayOfClass()
        {
            array = Enumerable.Range(0, Count).Select(x=> new Class(x)).ToArray();
            sysEnumerable = array;
            arrayEnumerable = array.ToRefTypedEnumerable();
        }

        [Benchmark(Baseline = true)]
        public int ForEachOnIEnumerable()
        {
            int sum = 0;
            foreach (var @class in sysEnumerable)
            {
                sum += @class.Integer;
            }
            return sum;
        }

        [Benchmark]
        public int ForEachOnArray()
        {
            int sum = 0;
            foreach (var @class in array)
            {
                sum += @class.Integer;
            }
            return sum;
        }

        [Benchmark]
        public int StructEnumerableArray()
        {
            var sumAction = new SumOfClass { Sum = 0 };
            arrayEnumerable.ForEach(ref sumAction, x => x);
            return sumAction.Sum;
        }

        [Benchmark]
        public int Direct()
        {
            using (var enumerator = arrayEnumerable.GetStructEnumerator())
            {
                var sum = 0;
                while (enumerator.MoveNext())
                {
                    sum += enumerator.Current.Integer;
                }
                return sum;
            }
        }


        private sealed class Class
        {
            public readonly int Integer;
            public Class(int integer)
            {
                Integer = integer;
            }
        }

        private struct SumOfClass : IAction<Class>
        {
            public int Sum { get; set; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Do(Class element)
            {
                Sum += element.Integer;
            }
        }
    }
}