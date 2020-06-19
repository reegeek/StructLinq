

// Generated code

using System;
using System.Runtime.CompilerServices;
 

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 SumInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 SumInt16<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 SumInt16<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Int16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int16>
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Int16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int16> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Int16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16<T,TEnumerator, IFunction<T,Int16>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int16>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 SumInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 SumInt32<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 SumInt32<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Int32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int32>
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Int32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int32> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Int32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32<T,TEnumerator, IFunction<T,Int32>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int32>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 SumInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 SumInt64<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 SumInt64<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Int64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int64>
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Int64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int64> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Int64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64<T,TEnumerator, IFunction<T,Int64>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int64>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 SumUInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 SumUInt16<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 SumUInt16<T,TEnumerator>(ref TEnumerator enumerator, Func<T, UInt16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt16>
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, UInt16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt16> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,UInt16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16<T,TEnumerator, IFunction<T,UInt16>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt16>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 SumUInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 SumUInt32<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 SumUInt32<T,TEnumerator>(ref TEnumerator enumerator, Func<T, UInt32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt32>
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, UInt32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt32> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,UInt32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32<T,TEnumerator, IFunction<T,UInt32>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt32>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 SumUInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 SumUInt64<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 SumUInt64<T,TEnumerator>(ref TEnumerator enumerator, Func<T, UInt64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt64>
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, UInt64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt64> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,UInt64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64<T,TEnumerator, IFunction<T,UInt64>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt64>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single SumSingle<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single SumSingle<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single SumSingle<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Single> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Single>
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Single> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Single> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Single> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle<T,TEnumerator, IFunction<T,Single>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Single>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double SumDouble<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double SumDouble<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double SumDouble<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Double> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Double>
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Double> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Double> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Double> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble<T,TEnumerator, IFunction<T,Double>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Double>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte SumByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte SumByte<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte SumByte<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Byte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Byte>
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Byte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Byte> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Byte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte<T,TEnumerator, IFunction<T,Byte>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Byte>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte SumSByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte SumSByte<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte SumSByte<T,TEnumerator>(ref TEnumerator enumerator, Func<T, SByte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<SByte>
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, SByte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, SByte> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,SByte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte<T,TEnumerator, IFunction<T,SByte>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,SByte>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }

}