using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using StructLinq.Array;
using StructLinq.IEnumerable;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    public class Array
    {
        private readonly ITypedEnumerable<int, ArrayStructEnumerator<int>> safeArray;
        private readonly SumIntAction[] sumActions = new SumIntAction[1];
        private const int Count = 10000;
        private readonly IEnumerable<int> sysEnumerable;
        private readonly ITypedEnumerable<int, GenericEnumerator<int>> convertArray;
        private readonly int[] array;
        public Array()
        {
            array = Enumerable.Range(0, Count).ToArray();
            sysEnumerable = array;
            safeArray = array.ToTypedEnumerable();
            convertArray = ((IEnumerable<int>) array).ToTypedEnumerable();
        }

        [Benchmark(Baseline = true)]
        public int EnumArray()
        {
            int sum = 0;
            foreach (var i in sysEnumerable)
            {
                sum += i;
            }
            return sum;
        }

        [Benchmark]
        public int SysArray()
        {
            int sum = 0;
            foreach (var i in array)
            {
                sum+=i;
            }
            return sum;
        }

        [Benchmark]
        public int UnsafeArray()
        {
            ref SumIntAction sumAction = ref sumActions[0];
            sumAction.Sum = 0;
            safeArray.ForEach(ref sumAction);
            return sumAction.Sum;
        }
        [Benchmark]
        public int ConvertArray()
        {
            ref SumIntAction sumAction = ref sumActions[0];
            sumAction.Sum = 0;
            convertArray.ForEach(ref sumAction);
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