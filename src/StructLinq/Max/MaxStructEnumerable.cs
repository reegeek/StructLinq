
// Generated code

using System;
using System.Runtime.CompilerServices;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        private struct MaxInt16Visitor : IVisitor<Int16>
        {
            public bool HasMax;
            public Int16 Max;
            public MaxInt16Visitor(bool hasMax, Int16 max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int16 input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Max<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var maxVisitor = new MaxInt16Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var maxVisitor = new MaxInt16Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxInt32Visitor : IVisitor<Int32>
        {
            public bool HasMax;
            public Int32 Max;
            public MaxInt32Visitor(bool hasMax, Int32 max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int32 input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Max<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var maxVisitor = new MaxInt32Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var maxVisitor = new MaxInt32Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxInt64Visitor : IVisitor<Int64>
        {
            public bool HasMax;
            public Int64 Max;
            public MaxInt64Visitor(bool hasMax, Int64 max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int64 input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Max<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var maxVisitor = new MaxInt64Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var maxVisitor = new MaxInt64Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxUInt16Visitor : IVisitor<UInt16>
        {
            public bool HasMax;
            public UInt16 Max;
            public MaxUInt16Visitor(bool hasMax, UInt16 max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt16 input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Max<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var maxVisitor = new MaxUInt16Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var maxVisitor = new MaxUInt16Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxUInt32Visitor : IVisitor<UInt32>
        {
            public bool HasMax;
            public UInt32 Max;
            public MaxUInt32Visitor(bool hasMax, UInt32 max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt32 input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Max<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var maxVisitor = new MaxUInt32Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var maxVisitor = new MaxUInt32Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxUInt64Visitor : IVisitor<UInt64>
        {
            public bool HasMax;
            public UInt64 Max;
            public MaxUInt64Visitor(bool hasMax, UInt64 max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt64 input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Max<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var maxVisitor = new MaxUInt64Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var maxVisitor = new MaxUInt64Visitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxSingleVisitor : IVisitor<Single>
        {
            public bool HasMax;
            public Single Max;
            public MaxSingleVisitor(bool hasMax, Single max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Single input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Max<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var maxVisitor = new MaxSingleVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var maxVisitor = new MaxSingleVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxDoubleVisitor : IVisitor<Double>
        {
            public bool HasMax;
            public Double Max;
            public MaxDoubleVisitor(bool hasMax, Double max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Double input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Max<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var maxVisitor = new MaxDoubleVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var maxVisitor = new MaxDoubleVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxByteVisitor : IVisitor<Byte>
        {
            public bool HasMax;
            public Byte Max;
            public MaxByteVisitor(bool hasMax, Byte max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Byte input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Max<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var maxVisitor = new MaxByteVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var maxVisitor = new MaxByteVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxSByteVisitor : IVisitor<SByte>
        {
            public bool HasMax;
            public SByte Max;
            public MaxSByteVisitor(bool hasMax, SByte max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(SByte input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Max<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var maxVisitor = new MaxSByteVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var maxVisitor = new MaxSByteVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


    public static partial class StructEnumerable
    {
        private struct MaxDateTimeVisitor : IVisitor<DateTime>
        {
            public bool HasMax;
            public DateTime Max;
            public MaxDateTimeVisitor(bool hasMax, DateTime max)
            {
                HasMax = hasMax;
                Max = max;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(DateTime input)
            {
                if (!HasMax)
                {
                    Max = input;
                    HasMax = true;
                    return true;
                }
                if (Max < input)
                    Max = input;
                return true;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Max<TEnumerator>(this IStructEnumerable<DateTime, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<DateTime>
        {
            var maxVisitor = new MaxDateTimeVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DateTime Max<TEnumerable,TEnumerator>(this TEnumerable enumerable, Func<TEnumerable,IStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<DateTime, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<DateTime>
        {
            var maxVisitor = new MaxDateTimeVisitor(false, default);
            enumerable.Visit(ref maxVisitor);
            if (!maxVisitor.HasMax)
                throw new ArgumentOutOfRangeException("No elements");
            return maxVisitor.Max;
        }

    }


}
