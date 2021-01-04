
using System;
using System.Runtime.CompilerServices;
using StructLinq.Contains;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
                
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int16 x,
            Func<TEnumerable, IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int16>
            where TEnumerable : IStructEnumerable<Int16, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<Int16, TEnumerator> enumerable, Int16 x)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int16 x, Func<TEnumerable, IStructCollection<Int16, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<Int16>
            where TEnumerable : IStructCollection<Int16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<Int16, TEnumerator> enumerable, Int16 x)
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int16 x,
            Func<TEnumerable, IRefStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int16>
            where TEnumerable : struct, IRefStructEnumerable<Int16, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<Int16, TEnumerator> enumerable, Int16 x)
            where TEnumerator : struct, IRefStructEnumerator<Int16>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int32 x,
            Func<TEnumerable, IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int32>
            where TEnumerable : IStructEnumerable<Int32, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<Int32, TEnumerator> enumerable, Int32 x)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int32 x, Func<TEnumerable, IStructCollection<Int32, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<Int32>
            where TEnumerable : IStructCollection<Int32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<Int32, TEnumerator> enumerable, Int32 x)
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int32 x,
            Func<TEnumerable, IRefStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int32>
            where TEnumerable : struct, IRefStructEnumerable<Int32, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<Int32, TEnumerator> enumerable, Int32 x)
            where TEnumerator : struct, IRefStructEnumerator<Int32>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int64 x,
            Func<TEnumerable, IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int64>
            where TEnumerable : IStructEnumerable<Int64, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<Int64, TEnumerator> enumerable, Int64 x)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int64 x, Func<TEnumerable, IStructCollection<Int64, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<Int64>
            where TEnumerable : IStructCollection<Int64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<Int64, TEnumerator> enumerable, Int64 x)
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Int64 x,
            Func<TEnumerable, IRefStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int64>
            where TEnumerable : struct, IRefStructEnumerable<Int64, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<Int64, TEnumerator> enumerable, Int64 x)
            where TEnumerator : struct, IRefStructEnumerator<Int64>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt16 x,
            Func<TEnumerable, IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt16>
            where TEnumerable : IStructEnumerable<UInt16, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<UInt16, TEnumerator> enumerable, UInt16 x)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt16 x, Func<TEnumerable, IStructCollection<UInt16, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
            where TEnumerable : IStructCollection<UInt16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<UInt16, TEnumerator> enumerable, UInt16 x)
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt16 x,
            Func<TEnumerable, IRefStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
            where TEnumerable : struct, IRefStructEnumerable<UInt16, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<UInt16, TEnumerator> enumerable, UInt16 x)
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt32 x,
            Func<TEnumerable, IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt32>
            where TEnumerable : IStructEnumerable<UInt32, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<UInt32, TEnumerator> enumerable, UInt32 x)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt32 x, Func<TEnumerable, IStructCollection<UInt32, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
            where TEnumerable : IStructCollection<UInt32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<UInt32, TEnumerator> enumerable, UInt32 x)
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt32 x,
            Func<TEnumerable, IRefStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
            where TEnumerable : struct, IRefStructEnumerable<UInt32, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<UInt32, TEnumerator> enumerable, UInt32 x)
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt64 x,
            Func<TEnumerable, IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt64>
            where TEnumerable : IStructEnumerable<UInt64, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<UInt64, TEnumerator> enumerable, UInt64 x)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt64 x, Func<TEnumerable, IStructCollection<UInt64, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
            where TEnumerable : IStructCollection<UInt64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<UInt64, TEnumerator> enumerable, UInt64 x)
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, UInt64 x,
            Func<TEnumerable, IRefStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
            where TEnumerable : struct, IRefStructEnumerable<UInt64, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<UInt64, TEnumerator> enumerable, UInt64 x)
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Single x,
            Func<TEnumerable, IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Single>
            where TEnumerable : IStructEnumerable<Single, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Single, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<Single, TEnumerator> enumerable, Single x)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Single, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Single x, Func<TEnumerable, IStructCollection<Single, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<Single>
            where TEnumerable : IStructCollection<Single, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<Single, TEnumerator> enumerable, Single x)
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Single x,
            Func<TEnumerable, IRefStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Single>
            where TEnumerable : struct, IRefStructEnumerable<Single, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<Single, TEnumerator> enumerable, Single x)
            where TEnumerator : struct, IRefStructEnumerator<Single>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Double x,
            Func<TEnumerable, IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Double>
            where TEnumerable : IStructEnumerable<Double, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Double, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<Double, TEnumerator> enumerable, Double x)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Double, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Double x, Func<TEnumerable, IStructCollection<Double, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<Double>
            where TEnumerable : IStructCollection<Double, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<Double, TEnumerator> enumerable, Double x)
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Double x,
            Func<TEnumerable, IRefStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Double>
            where TEnumerable : struct, IRefStructEnumerable<Double, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<Double, TEnumerator> enumerable, Double x)
            where TEnumerator : struct, IRefStructEnumerator<Double>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Byte x,
            Func<TEnumerable, IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Byte>
            where TEnumerable : IStructEnumerable<Byte, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Byte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<Byte, TEnumerator> enumerable, Byte x)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Byte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Byte x, Func<TEnumerable, IStructCollection<Byte, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<Byte>
            where TEnumerable : IStructCollection<Byte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<Byte, TEnumerator> enumerable, Byte x)
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, Byte x,
            Func<TEnumerable, IRefStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Byte>
            where TEnumerable : struct, IRefStructEnumerable<Byte, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<Byte, TEnumerator> enumerable, Byte x)
            where TEnumerator : struct, IRefStructEnumerator<Byte>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, SByte x,
            Func<TEnumerable, IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<SByte>
            where TEnumerable : IStructEnumerable<SByte, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<SByte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<SByte, TEnumerator> enumerable, SByte x)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<SByte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, SByte x, Func<TEnumerable, IStructCollection<SByte, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<SByte>
            where TEnumerable : IStructCollection<SByte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<SByte, TEnumerator> enumerable, SByte x)
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, SByte x,
            Func<TEnumerable, IRefStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<SByte>
            where TEnumerable : struct, IRefStructEnumerable<SByte, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<SByte, TEnumerator> enumerable, SByte x)
            where TEnumerator : struct, IRefStructEnumerator<SByte>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, DateTime x,
            Func<TEnumerable, IStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<DateTime>
            where TEnumerable : IStructEnumerable<DateTime, TEnumerator>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<DateTime, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(
            this IStructEnumerable<DateTime, TEnumerator> enumerable, DateTime x)
            where TEnumerator : struct, IStructEnumerator<DateTime>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<DateTime, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, DateTime x, Func<TEnumerable, IStructCollection<DateTime, TEnumerator>> _)
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
            where TEnumerable : IStructCollection<DateTime, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerator>(this IStructCollection<DateTime, TEnumerator> enumerable, DateTime x)
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var enumerator = enumerable.GetEnumerator();
            var equalityComparer = new DefaultStructEqualityComparer();
            return InnerCollectionContains(enumerator, x, equalityComparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(this TEnumerable enumerable, DateTime x,
            Func<TEnumerable, IRefStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<DateTime>
            where TEnumerable : struct, IRefStructEnumerable<DateTime, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this IRefStructEnumerable<DateTime, TEnumerator> enumerable, DateTime x)
            where TEnumerator : struct, IRefStructEnumerator<DateTime>
        {
            var comparer = new DefaultStructInEqualityComparer();
            var enumerator = enumerable.GetEnumerator();
            return RefInnerContains(enumerator, x, comparer);
        }

    
    }
}
