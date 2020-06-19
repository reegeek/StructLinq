
// Generated code

using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 MinInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Int16 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Min<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt16(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 MinInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Int32 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Min<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt32(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 MinInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Int64 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Min<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt64(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 MinUInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			UInt16 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Min<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt16(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 MinUInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			UInt32 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Min<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt32(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 MinUInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			UInt64 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Min<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt64(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single MinSingle<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Single result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Min<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinSingle(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double MinDouble<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Double result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Min<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinDouble(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte MinByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Byte result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Min<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinByte(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte MinSByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
        	if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			SByte result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Min<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinSByte(ref enumerator);
        }

    }


}
