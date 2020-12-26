
// Generated code

using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 MaxCollectionInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Int16 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Max<TEnumerator>(this IStructCollection<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Int16, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int16, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionInt16(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 MaxCollectionInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Int32 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Max<TEnumerator>(this IStructCollection<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Int32, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int32, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionInt32(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 MaxCollectionInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Int64 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Max<TEnumerator>(this IStructCollection<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Int64, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int64, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionInt64(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 MaxCollectionUInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			UInt16 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Max<TEnumerator>(this IStructCollection<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<UInt16, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt16, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionUInt16(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 MaxCollectionUInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			UInt32 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Max<TEnumerator>(this IStructCollection<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<UInt32, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt32, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionUInt32(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 MaxCollectionUInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			UInt64 result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Max<TEnumerator>(this IStructCollection<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<UInt64, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt64, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionUInt64(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single MaxCollectionSingle<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Single result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Max<TEnumerator>(this IStructCollection<Single, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Single, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Single, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionSingle(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double MaxCollectionDouble<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Double result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Max<TEnumerator>(this IStructCollection<Double, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Double, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Double, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionDouble(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte MaxCollectionByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			Byte result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Max<TEnumerator>(this IStructCollection<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<Byte, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Byte, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionByte(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte MaxCollectionSByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			SByte result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Max<TEnumerator>(this IStructCollection<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<SByte, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<SByte, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionSByte(ref enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static DateTime MaxCollectionDateTime<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var count = enumerator.Count;
            if (count == 0)
				throw new ArgumentOutOfRangeException("No elements");
			DateTime result = enumerator.Get(0);
            for(int i = 1;i < count; i++)
			{
				var current = enumerator.Get(i);
				if (result < current)
					result = current;
			}
            enumerator.Dispose();
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Max<TEnumerator>(this IStructCollection<DateTime, TEnumerator> enumerable)
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionDateTime(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructCollection<DateTime, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<DateTime, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxCollectionDateTime(ref enumerator);
        }

    }


}
