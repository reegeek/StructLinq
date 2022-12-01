
// Generated code

using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        private struct MinInt16Visitor : IVisitor<Int16>
        {
            public bool HasMin;
            public Int16 Min;
            public MinInt16Visitor(bool hasMin, Int16 min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int16 input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Min<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var minVisitor = new MinInt16Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var minVisitor = new MinInt16Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinInt32Visitor : IVisitor<Int32>
        {
            public bool HasMin;
            public Int32 Min;
            public MinInt32Visitor(bool hasMin, Int32 min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int32 input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Min<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var minVisitor = new MinInt32Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var minVisitor = new MinInt32Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinInt64Visitor : IVisitor<Int64>
        {
            public bool HasMin;
            public Int64 Min;
            public MinInt64Visitor(bool hasMin, Int64 min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int64 input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Min<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var minVisitor = new MinInt64Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var minVisitor = new MinInt64Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinUInt16Visitor : IVisitor<UInt16>
        {
            public bool HasMin;
            public UInt16 Min;
            public MinUInt16Visitor(bool hasMin, UInt16 min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt16 input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Min<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var minVisitor = new MinUInt16Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var minVisitor = new MinUInt16Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinUInt32Visitor : IVisitor<UInt32>
        {
            public bool HasMin;
            public UInt32 Min;
            public MinUInt32Visitor(bool hasMin, UInt32 min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt32 input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Min<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var minVisitor = new MinUInt32Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var minVisitor = new MinUInt32Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinUInt64Visitor : IVisitor<UInt64>
        {
            public bool HasMin;
            public UInt64 Min;
            public MinUInt64Visitor(bool hasMin, UInt64 min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt64 input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Min<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var minVisitor = new MinUInt64Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var minVisitor = new MinUInt64Visitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinSingleVisitor : IVisitor<Single>
        {
            public bool HasMin;
            public Single Min;
            public MinSingleVisitor(bool hasMin, Single min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Single input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Min<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var minVisitor = new MinSingleVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var minVisitor = new MinSingleVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinDoubleVisitor : IVisitor<Double>
        {
            public bool HasMin;
            public Double Min;
            public MinDoubleVisitor(bool hasMin, Double min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Double input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Min<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var minVisitor = new MinDoubleVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var minVisitor = new MinDoubleVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinByteVisitor : IVisitor<Byte>
        {
            public bool HasMin;
            public Byte Min;
            public MinByteVisitor(bool hasMin, Byte min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Byte input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Min<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var minVisitor = new MinByteVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var minVisitor = new MinByteVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinSByteVisitor : IVisitor<SByte>
        {
            public bool HasMin;
            public SByte Min;
            public MinSByteVisitor(bool hasMin, SByte min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(SByte input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Min<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var minVisitor = new MinSByteVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var minVisitor = new MinSByteVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MinDateTimeVisitor : IVisitor<DateTime>
        {
            public bool HasMin;
            public DateTime Min;
            public MinDateTimeVisitor(bool hasMin, DateTime min)
            {
                HasMin = hasMin;
                Min = min;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(DateTime input)
            {
                if (!HasMin)
                {
                    Min = input;
                    HasMin = true;
                    return true;
                }
                if (Min > input)
                    Min = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Min<TEnumerator>(this IStructEnumerable<DateTime, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<DateTime>
        {
            var minVisitor = new MinDateTimeVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Min<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<DateTime, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<DateTime>
        {
            var minVisitor = new MinDateTimeVisitor(false, default);
            enumerable.Visit(ref minVisitor);
            if (!minVisitor.HasMin)
                throw new ArgumentOutOfRangeException("No elements");
            return minVisitor.Min;
        }

    }


}
