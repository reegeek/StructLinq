using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using StructLinq.Array;

namespace StructLinq.Benchmark
{
    [MemoryDiagnoser]
    //[SimpleJob(RuntimeMoniker.Net48)]
    public class ArrayOfClass
    {
        private RefArrayEnumerable<Class> arrayEnumerable;
        private const int Count = 10000;
        private readonly IEnumerable<Class> sysEnumerable;
        private readonly Class[] array;
        public ArrayOfClass()
        {
            array = Enumerable.Range(0, Count).Select(x=> new Class(x)).ToArray();
            sysEnumerable = array;
            arrayEnumerable = array.ToRefTypedEnumerable();
        }

        //[Benchmark(Baseline = true)]
        public int ForEachOnIEnumerable()
        {
            int sum = 0;
            foreach (var @class in sysEnumerable)
            {
                sum += @class.Integer;
            }
            return sum;
        }

        //[Benchmark]
        public int ForEachOnArray()
        {
            int sum = 0;
            foreach (var @class in array)
            {
                sum += @class.Integer;
            }
            return sum;
        }

        //[Benchmark]
        public int StructEnumerableArray()
        {
            var sumAction = new RefSumOfClass { Sum = 0 };
            arrayEnumerable.ForEach(ref sumAction, x => x);
            return sumAction.Sum;
        }

        //[Benchmark]
        public int StructEnumerableArray2()
        {
            var sumAction = new RefSumOfClass { Sum = 0 };
            StructEnumerable.ForEach(arrayEnumerable, ref sumAction, x=> x);
            return sumAction.Sum;
        }


        //[Benchmark]
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


        //[Benchmark]
        public int Indirect()
        {
            var sumAction = new SumOfClass { Sum = 0 };
            using (var enumerator = arrayEnumerable.GetStructEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var current = enumerator.Current;
                    sumAction.Do(current);
                }
                return sumAction.Sum;
            }
        }

        //[Benchmark]
        public int Indirect2()
        {
            var sumAction = new SumOfClass {Sum = 0};
            var enumerator = arrayEnumerable.GetStructEnumerator();
            ForEach2(ref enumerator, ref sumAction, x => x);
            return sumAction.Sum;
        }

        //[Benchmark]
        public int Indirect3()
        {
            var sumAction = new SumOfClass { Sum = 0 };
            var enumerator = arrayEnumerable.GetStructEnumerator();
            ForEach3(ref enumerator, ref sumAction, x => x);
            return sumAction.Sum;
        }

        [Benchmark]
        public int Indirect4()
        {
            var sumAction = new SumOfClass { Sum = 0 };

            ForEach(ref arrayEnumerable, ref sumAction, x => x);
            return sumAction.Sum;
        }

        [Benchmark]
        public int Indirect5()
        {
            var sumAction = new SumOfClass { Sum = 0 };

            ForEach2(ref arrayEnumerable, ref sumAction, x => x);
            return sumAction.Sum;
        }


        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T, TEnumerator, TAction>(ref TEnumerator enumerator, ref TAction action, Func<TEnumerator, IEnumerator<T>> _)
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IRefAction<T>
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                action.Do(ref current);
            }
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ForEach2<T, TEnumerator, TAction>(ref TEnumerator enumerator, ref TAction action, Func<TEnumerator, IEnumerator<T>> _)
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
            where T : class
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                action.Do(current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach3<T, TEnumerator, TAction>(ref TEnumerator enumerator, ref TAction action, Func<TEnumerator, IEnumerator<T>> _)
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
            where T : class
        {
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                action.Do(current);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach<T, TEnumerator, TAction, TEnumerable>(ref TEnumerable enumerable, ref TAction action,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where T : class
        {
            var enumerator = enumerable.GetStructEnumerator();
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                action.Do(current);
            }

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void ForEach2<T, TEnumerator, TAction, TEnumerable>(ref TEnumerable enumerable, ref TAction action,
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerator : struct, IEnumerator<T>
            where TAction : struct, IAction<T>
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where T : class
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var current = enumerator.Current;
                    action.Do(current);
                }
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

        private struct RefSumOfClass : IRefAction<Class>, StructLinq.IAction<Class>
        {
            public int Sum { get; set; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Do(ref Class element)
            {
                Sum += element.Integer;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Do(Class element)
            {
                Sum += element.Integer;
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

        public interface IRefAction<T>
        {
            void Do(ref T element);
        }

        public interface IAction<in T> where T : class
        {
            void Do(T element);
        }


    }
}