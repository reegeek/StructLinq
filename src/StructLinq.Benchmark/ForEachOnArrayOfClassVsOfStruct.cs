using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.Array;
using StructLinq.Select;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net48)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public class SumOnArrayOfClassVsOfStruct
    {
        private readonly ClassContainer[] sysRange;
        private readonly SelectEnumerable<StructContainer, int, ArrayStructEnumerator<StructContainer>, StructFunction<StructContainer, int>> arrayOfStructEnumerable;
        private readonly SelectEnumerable<ClassContainer, int, ArrayStructEnumerator<ClassContainer>, StructFunction<ClassContainer, int>> arrayOfClassEnumerable;
        private const int Count = 10000;
        public SumOnArrayOfClassVsOfStruct()
        {
            sysRange = Enumerable.Range(0, Count).Select(x=> new ClassContainer(x)).ToArray();
            arrayOfClassEnumerable = Enumerable.Range(0, Count).Select(x=> new ClassContainer(x)).ToArray().ToTypedEnumerable().Select(x=> x.Index);
            arrayOfStructEnumerable = Enumerable.Range(0, Count).Select(x => new StructContainer(x)).ToArray().ToTypedEnumerable().Select(x => x.Index);
        }

        [Benchmark(Baseline = true)]
        public int SysSum()
        {
            int sum = 0;
            foreach (var i in sysRange)
            {
                sum += i.Index;
            }
            return sum;
        }

        [Benchmark]
        public int StructSum()
        {
            return arrayOfStructEnumerable.Sum();
        }

        [Benchmark]
        public int ClassSum()
        {
            return arrayOfClassEnumerable.Sum();
        }

        private sealed class ClassContainer
        {
            public int Index
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get;
            }

            public ClassContainer(int index)
            {
                Index = index;
            }
        }

        private sealed class StructContainer
        {
            public int Index
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get;
            }

            public StructContainer(int index)
            {
                Index = index;
            }
        }

    }


}
