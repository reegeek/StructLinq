

// Generated code

using System;
using System.Collections.Generic;
 

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
        private static Int16 SumInt16<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static Int16 Sum<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int16>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumInt16(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static Int32 SumInt32<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static Int32 Sum<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int32>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumInt32(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static Int64 SumInt64<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static Int64 Sum<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int64>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumInt64(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static UInt16 SumUInt16<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static UInt16 Sum<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt16>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumUInt16(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static UInt32 SumUInt32<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static UInt32 Sum<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt32>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumUInt32(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static UInt64 SumUInt64<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static UInt64 Sum<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt64>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumUInt64(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static Single SumSingle<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static Single Sum<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Single>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumSingle(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static Double SumDouble<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static Double Sum<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Double>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumDouble(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static Byte SumByte<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static Byte Sum<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Byte>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumByte(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        private static SByte SumSByte<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        public static SByte Sum<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<SByte>
        {
            using (var enumerator = enumerable.GetStructEnumerator())
            {
                return SumSByte(enumerator);
            }
        }
    }

}