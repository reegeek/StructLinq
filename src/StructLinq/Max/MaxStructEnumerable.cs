

// Generated code

using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        public static Int16 Max<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int16>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static Int32 Max<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int32>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static Int64 Max<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int64>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt16 Max<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt16>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt32 Max<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt32>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt64 Max<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt64>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static Single Max<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Single>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static Double Max<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Double>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static Byte Max<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Byte>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


    public static partial class StructEnumerable
    {
        public static SByte Max<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<SByte>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
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
        }
    }


}
