
using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using StructLinq.Distinct;
using StructLinq.Utils.Collections;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
                
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Int16, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int16>
            where TEnumerable : IStructEnumerable<Int16, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int16>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Int16, IStructEnumerable<Int16, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int16>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Int16, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int16>
            where TEnumerable : struct, IRefStructEnumerable<Int16, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Int16, IRefStructEnumerable<Int16, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Int16>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int16>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Int32, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int32>
            where TEnumerable : IStructEnumerable<Int32, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int32>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Int32, IStructEnumerable<Int32, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int32>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Int32, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int32>
            where TEnumerable : struct, IRefStructEnumerable<Int32, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Int32, IRefStructEnumerable<Int32, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Int32>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int32>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Int64, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int64>
            where TEnumerable : IStructEnumerable<Int64, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int64>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Int64, IStructEnumerable<Int64, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int64>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Int64, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int64>
            where TEnumerable : struct, IRefStructEnumerable<Int64, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Int64, IRefStructEnumerable<Int64, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Int64>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Int64>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<UInt16, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt16>
            where TEnumerable : IStructEnumerable<UInt16, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt16>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<UInt16, IStructEnumerable<UInt16, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt16>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<UInt16, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
            where TEnumerable : struct, IRefStructEnumerable<UInt16, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<UInt16, IRefStructEnumerable<UInt16, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt16>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<UInt32, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt32>
            where TEnumerable : IStructEnumerable<UInt32, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt32>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<UInt32, IStructEnumerable<UInt32, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt32>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<UInt32, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
            where TEnumerable : struct, IRefStructEnumerable<UInt32, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<UInt32, IRefStructEnumerable<UInt32, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt32>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<UInt64, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt64>
            where TEnumerable : IStructEnumerable<UInt64, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt64>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<UInt64, IStructEnumerable<UInt64, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt64>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<UInt64, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
            where TEnumerable : struct, IRefStructEnumerable<UInt64, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<UInt64, IRefStructEnumerable<UInt64, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<UInt64>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Single, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Single>
            where TEnumerable : IStructEnumerable<Single, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Single>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Single, IStructEnumerable<Single, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Single>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Single, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Single>
            where TEnumerable : struct, IRefStructEnumerable<Single, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Single, IRefStructEnumerable<Single, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Single>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Single>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Double, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Double>
            where TEnumerable : IStructEnumerable<Double, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Double>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Double, IStructEnumerable<Double, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Double>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Double, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Double>
            where TEnumerable : struct, IRefStructEnumerable<Double, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Double, IRefStructEnumerable<Double, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Double>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Double>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Byte, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Byte>
            where TEnumerable : IStructEnumerable<Byte, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Byte>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<Byte, IStructEnumerable<Byte, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Byte>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Byte, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Byte>
            where TEnumerable : struct, IRefStructEnumerable<Byte, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<Byte, IRefStructEnumerable<Byte, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<Byte>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<Byte>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<SByte, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<SByte>
            where TEnumerable : IStructEnumerable<SByte, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<SByte>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<SByte, IStructEnumerable<SByte, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<SByte>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<SByte, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<SByte>
            where TEnumerable : struct, IRefStructEnumerable<SByte, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<SByte, IRefStructEnumerable<SByte, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<SByte>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<SByte>>.Shared);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<DateTime, TEnumerable, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<DateTime>
            where TEnumerable : IStructEnumerable<DateTime, TEnumerator>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<DateTime>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DistinctEnumerable<DateTime, IStructEnumerable<DateTime, TEnumerator>, TEnumerator, DefaultStructEqualityComparer> Distinct<TEnumerator>(
            this IStructEnumerable<DateTime, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<DateTime>
        {
            var equalityComparer = new DefaultStructEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<DateTime>>.Shared);
        }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<DateTime, TEnumerable, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerable, TEnumerator>(this TEnumerable enumerable,
            Func<TEnumerable, IRefStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<DateTime>
            where TEnumerable : struct, IRefStructEnumerable<DateTime, TEnumerator>
        {
            return enumerable.Distinct(new DefaultStructInEqualityComparer(), _);
        }
        
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RefDistinctEnumerable<DateTime, IRefStructEnumerable<DateTime, TEnumerator>, TEnumerator, DefaultStructInEqualityComparer> Distinct<TEnumerator>(
            this IRefStructEnumerable<DateTime, TEnumerator> enumerable)
            where TEnumerator : struct, IRefStructEnumerator<DateTime>
        {
            var equalityComparer = new DefaultStructInEqualityComparer();
            return new(ref enumerable, equalityComparer, 0, ArrayPool<int>.Shared, ArrayPool<Slot<DateTime>>.Shared);
        }

    
    }
}
