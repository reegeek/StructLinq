

// Generated code

using System;
using System.Runtime.CompilerServices;
 

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 RefSumInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 RefSumInt16<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 RefSumInt16<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, Int16> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerator>(this IRefStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int16>
            where TEnumerable : struct, IRefStructEnumerable<Int16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, Int16> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, Int16> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,Int16> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt16<T,TEnumerator, IInFunction<T,Int16>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,Int16>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt16<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 RefSumInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 RefSumInt32<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 RefSumInt32<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, Int32> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerator>(this IRefStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int32>
            where TEnumerable : struct, IRefStructEnumerable<Int32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, Int32> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, Int32> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,Int32> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt32<T,TEnumerator, IInFunction<T,Int32>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,Int32>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt32<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 RefSumInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 RefSumInt64<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 RefSumInt64<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, Int64> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerator>(this IRefStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int64>
            where TEnumerable : struct, IRefStructEnumerable<Int64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, Int64> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, Int64> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,Int64> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt64<T,TEnumerator, IInFunction<T,Int64>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,Int64>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumInt64<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 RefSumUInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 RefSumUInt16<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 RefSumUInt16<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, UInt16> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerator>(this IRefStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
            where TEnumerable : struct, IRefStructEnumerable<UInt16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, UInt16> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, UInt16> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,UInt16> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt16<T,TEnumerator, IInFunction<T,UInt16>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,UInt16>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt16<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 RefSumUInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 RefSumUInt32<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 RefSumUInt32<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, UInt32> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerator>(this IRefStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
            where TEnumerable : struct, IRefStructEnumerable<UInt32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, UInt32> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, UInt32> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,UInt32> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt32<T,TEnumerator, IInFunction<T,UInt32>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,UInt32>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt32<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 RefSumUInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 RefSumUInt64<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 RefSumUInt64<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, UInt64> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerator>(this IRefStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
            where TEnumerable : struct, IRefStructEnumerable<UInt64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, UInt64> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, UInt64> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,UInt64> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt64<T,TEnumerator, IInFunction<T,UInt64>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,UInt64>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumUInt64<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single RefSumSingle<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single RefSumSingle<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single RefSumSingle<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, Single> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerator>(this IRefStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Single>
            where TEnumerable : struct, IRefStructEnumerable<Single, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, Single> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSingle(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, Single> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSingle(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,Single> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSingle<T,TEnumerator, IInFunction<T,Single>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,Single>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSingle<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double RefSumDouble<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double RefSumDouble<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double RefSumDouble<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, Double> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerator>(this IRefStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Double>
            where TEnumerable : struct, IRefStructEnumerable<Double, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, Double> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumDouble(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, Double> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumDouble(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,Double> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumDouble<T,TEnumerator, IInFunction<T,Double>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,Double>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumDouble<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte RefSumByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte RefSumByte<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte RefSumByte<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, Byte> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerator>(this IRefStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Byte>
            where TEnumerable : struct, IRefStructEnumerable<Byte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, Byte> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, Byte> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,Byte> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumByte<T,TEnumerator, IInFunction<T,Byte>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,Byte>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumByte<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte RefSumSByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IRefStructEnumerator<SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += current;
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte RefSumSByte<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func.Eval(in current);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte RefSumSByte<T,TEnumerator>(ref TEnumerator enumerator, InFunc<T, SByte> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                ref var current = ref enumerator.Current;
                result += func(in current);
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerator>(this IRefStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IRefStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<SByte>
            where TEnumerable : struct, IRefStructEnumerable<SByte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, InFunc<T, SByte> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, InFunc<T, SByte> func, Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerator>(this IRefStructEnumerable<T, TEnumerator> enumerable, IInFunction<T,SByte> func)
            where TEnumerator : struct, IRefStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSByte<T,TEnumerator, IInFunction<T,SByte>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IRefStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IInFunction<T,SByte>> __)
            where TEnumerable : struct, IRefStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<T>
            where TFunc : IInFunction<T,SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return RefSumSByte<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }

}