
using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        #region private fields
        private static Int16 Int16Min<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<Int16>
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
        #endregion
        public static Int16 Min<TEnumerator>(this ITypedEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<Int16>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return Int16Min(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Int32 Int32Min<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<Int32>
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
        #endregion
        public static Int32 Min<TEnumerator>(this ITypedEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<Int32>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return Int32Min(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Int64 Int64Min<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<Int64>
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
        #endregion
        public static Int64 Min<TEnumerator>(this ITypedEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<Int64>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return Int64Min(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static UInt16 UInt16Min<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<UInt16>
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
        #endregion
        public static UInt16 Min<TEnumerator>(this ITypedEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<UInt16>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return UInt16Min(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static UInt32 UInt32Min<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<UInt32>
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
        #endregion
        public static UInt32 Min<TEnumerator>(this ITypedEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<UInt32>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return UInt32Min(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static UInt64 UInt64Min<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<UInt64>
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
        #endregion
        public static UInt64 Min<TEnumerator>(this ITypedEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<UInt64>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return UInt64Min(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Single SingleMin<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<Single>
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
        #endregion
        public static Single Min<TEnumerator>(this ITypedEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<Single>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return SingleMin(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Double DoubleMin<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<Double>
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
        #endregion
        public static Double Min<TEnumerator>(this ITypedEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<Double>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return DoubleMin(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static Byte ByteMin<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<Byte>
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
        #endregion
        public static Byte Min<TEnumerator>(this ITypedEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<Byte>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return ByteMin(enumerator);
            }
        }
    }


    public static partial class StructEnumerable
    {
        #region private fields
        private static SByte SByteMin<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<SByte>
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
        #endregion
        public static SByte Min<TEnumerator>(this ITypedEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<SByte>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return SByteMin(enumerator);
            }
        }
    }


}
