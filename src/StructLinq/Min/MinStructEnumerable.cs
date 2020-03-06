
// Generated code

using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static Int16 MinInt16<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static Int16 Min<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt16(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static Int32 MinInt32<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static Int32 Min<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt32(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static Int64 MinInt64<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static Int64 Min<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinInt64(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt16 MinUInt16<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static UInt16 Min<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt16(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt32 MinUInt32<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static UInt32 Min<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt32(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt64 MinUInt64<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static UInt64 Min<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinUInt64(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static Single MinSingle<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static Single Min<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinSingle(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static Double MinDouble<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static Double Min<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinDouble(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static Byte MinByte<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static Byte Min<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinByte(enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        public static SByte MinSByte<TEnumerator>(TEnumerator enumerator)
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
			return result;
        }

        public static SByte Min<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinSByte(enumerator);
        }
    }


}
