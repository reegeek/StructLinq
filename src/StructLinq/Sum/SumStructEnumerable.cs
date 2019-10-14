

// Generated code

using System;
using System.Collections.Generic;
 

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
        public static Int16 Sum<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int16>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				Int16 result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Int32 Sum<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int32>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				Int32 result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Int64 Sum<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int64>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				Int64 result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt16 Sum<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt16>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				UInt16 result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt32 Sum<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt32>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				UInt32 result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static UInt64 Sum<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt64>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				UInt64 result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Single Sum<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Single>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				Single result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Double Sum<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Double>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				Double result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static Byte Sum<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Byte>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				Byte result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }


    public static partial class StructEnumerable
    {
        public static SByte Sum<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<SByte>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
				SByte result = 0;
				while (enumerator.MoveNext())
				{
					result += enumerator.Current;
				}
				return result;
            }
        }
    }

}