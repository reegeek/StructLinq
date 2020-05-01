

// Generated code

using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 MaxInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Int16 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Max<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static Int16 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxInt16(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 MaxInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Int32 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Max<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static Int32 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxInt32(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 MaxInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Int64 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Max<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static Int64 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxInt64(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 MaxUInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			UInt16 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Max<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static UInt16 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxUInt16(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 MaxUInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			UInt32 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Max<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static UInt32 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxUInt32(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 MaxUInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			UInt64 result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Max<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static UInt64 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxUInt64(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single MaxSingle<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Single result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Max<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static Single Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxSingle(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double MaxDouble<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Double result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Max<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static Double Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxDouble(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte MaxByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			Byte result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Max<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static Byte Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxByte(ref enumerator);
        }
    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte MaxSByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
			if (!enumerator.MoveNext())
				throw new ArgumentOutOfRangeException("No elements");
			SByte result = enumerator.Current;
			while (enumerator.MoveNext())
			{
				var current = enumerator.Current;
				if (current > result)
					result = current;
			}
			return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Max<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
       public static SByte Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return MaxSByte(ref enumerator);
        }
    }


}
