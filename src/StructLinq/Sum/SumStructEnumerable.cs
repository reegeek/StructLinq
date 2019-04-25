

// Generated code

using System;
using System.Collections.Generic;
 

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
        #region private fields
        private static Int16 Int16Sum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static Int16 Sum<TEnumerator>(this ITypedEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int16>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return Int16Sum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Int32 Int32Sum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static Int32 Sum<TEnumerator>(this ITypedEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int32>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return Int32Sum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Int64 Int64Sum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static Int64 Sum<TEnumerator>(this ITypedEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Int64>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return Int64Sum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static UInt16 UInt16Sum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static UInt16 Sum<TEnumerator>(this ITypedEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt16>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return UInt16Sum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static UInt32 UInt32Sum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static UInt32 Sum<TEnumerator>(this ITypedEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt32>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return UInt32Sum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static UInt64 UInt64Sum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static UInt64 Sum<TEnumerator>(this ITypedEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<UInt64>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return UInt64Sum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Single SingleSum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static Single Sum<TEnumerator>(this ITypedEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Single>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return SingleSum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Double DoubleSum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static Double Sum<TEnumerator>(this ITypedEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Double>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return DoubleSum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Byte ByteSum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static Byte Sum<TEnumerator>(this ITypedEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<Byte>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return ByteSum(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static SByte SByteSum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IEnumerator<SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static SByte Sum<TEnumerator>(this ITypedEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IEnumerator<SByte>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return SByteSum(enumerator);
            }
        }
    }

}