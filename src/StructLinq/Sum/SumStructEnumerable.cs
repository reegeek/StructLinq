

// Generated code

using System;
using System.Collections.Generic;
 

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
        public static Int16 Sum<TEnumerator>(this ITypedEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int16>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static Int32 Sum<TEnumerator>(this ITypedEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int32>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static Int64 Sum<TEnumerator>(this ITypedEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int64>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static UInt16 Sum<TEnumerator>(this ITypedEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt16>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static UInt32 Sum<TEnumerator>(this ITypedEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt32>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static UInt64 Sum<TEnumerator>(this ITypedEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt64>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static Single Sum<TEnumerator>(this ITypedEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Single>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static Double Sum<TEnumerator>(this ITypedEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Double>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static Byte Sum<TEnumerator>(this ITypedEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Byte>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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
        public static SByte Sum<TEnumerator>(this ITypedEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<SByte>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
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