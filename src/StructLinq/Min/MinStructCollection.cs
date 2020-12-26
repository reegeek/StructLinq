
// Generated code

using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 MinCollectionInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Int16 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Min<TEnumerator>(this IStructCollection<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Int16, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int16, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionInt16(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 MinCollectionInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Int32 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Min<TEnumerator>(this IStructCollection<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Int32, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int32, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionInt32(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 MinCollectionInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Int64 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Min<TEnumerator>(this IStructCollection<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Int64, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int64, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionInt64(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 MinCollectionUInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			UInt16 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Min<TEnumerator>(this IStructCollection<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<UInt16, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt16, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionUInt16(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 MinCollectionUInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			UInt32 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Min<TEnumerator>(this IStructCollection<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<UInt32, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt32, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionUInt32(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 MinCollectionUInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			UInt64 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Min<TEnumerator>(this IStructCollection<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<UInt64, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt64, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionUInt64(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single MinCollectionSingle<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Single result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Min<TEnumerator>(this IStructCollection<Single, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Single, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Single, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionSingle(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double MinCollectionDouble<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Double result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Min<TEnumerator>(this IStructCollection<Double, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Double, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Double, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionDouble(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte MinCollectionByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Byte result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Min<TEnumerator>(this IStructCollection<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Byte, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Byte, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionByte(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte MinCollectionSByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			SByte result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Min<TEnumerator>(this IStructCollection<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<SByte, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<SByte, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionSByte(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static DateTime MinCollectionDateTime<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			DateTime result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (current < result)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Min<TEnumerator>(this IStructCollection<DateTime, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionDateTime(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<DateTime, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<DateTime, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var enumerator = enumerable.GetEnumerator();
            return MinCollectionDateTime(ref enumerator);
        }

    }


}
