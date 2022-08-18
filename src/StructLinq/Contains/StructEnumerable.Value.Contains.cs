
using System;
using System.Runtime.CompilerServices;
using StructLinq.Contains;


// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
                
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<Int16, TEnumerable, TEnumerator> enumerable, Int16 x,
            Func<TEnumerable, IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<Int16, TEnumerable, TEnumerator> enumerable, Int16 x)
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<Int16, TEnumerable, TEnumerator> enumerable, Int16 x,
            Func<TEnumerable, IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int16, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<Int16, TEnumerable, TEnumerator> enumerable, Int16 x)
            where TEnumerable : struct, IStructCollection<Int16, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<Int16, TEnumerable, TEnumerator> enumerable, Int16 x,
            Func<TEnumerable, IRefStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int16>
            where TEnumerable : struct, IRefStructEnumerable<Int16, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<Int16, TEnumerable, TEnumerator> enumerable, Int16 x)
            where TEnumerable : struct, IRefStructEnumerable<Int16, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<Int16>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<Int16, TEnumerable, TEnumerator> enumerable, Int16 x,
            Func<TEnumerable, IRefStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<Int16>
            where TEnumerable : struct, IRefStructCollection<Int16, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<Int16, TEnumerable, TEnumerator> enumerable, Int16 x)
            where TEnumerable : struct, IRefStructCollection<Int16, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<Int16>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<Int32, TEnumerable, TEnumerator> enumerable, Int32 x,
            Func<TEnumerable, IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<Int32, TEnumerable, TEnumerator> enumerable, Int32 x)
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<Int32, TEnumerable, TEnumerator> enumerable, Int32 x,
            Func<TEnumerable, IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int32, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<Int32, TEnumerable, TEnumerator> enumerable, Int32 x)
            where TEnumerable : struct, IStructCollection<Int32, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<Int32, TEnumerable, TEnumerator> enumerable, Int32 x,
            Func<TEnumerable, IRefStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int32>
            where TEnumerable : struct, IRefStructEnumerable<Int32, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<Int32, TEnumerable, TEnumerator> enumerable, Int32 x)
            where TEnumerable : struct, IRefStructEnumerable<Int32, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<Int32>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<Int32, TEnumerable, TEnumerator> enumerable, Int32 x,
            Func<TEnumerable, IRefStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<Int32>
            where TEnumerable : struct, IRefStructCollection<Int32, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<Int32, TEnumerable, TEnumerator> enumerable, Int32 x)
            where TEnumerable : struct, IRefStructCollection<Int32, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<Int32>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<Int64, TEnumerable, TEnumerator> enumerable, Int64 x,
            Func<TEnumerable, IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<Int64, TEnumerable, TEnumerator> enumerable, Int64 x)
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<Int64, TEnumerable, TEnumerator> enumerable, Int64 x,
            Func<TEnumerable, IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Int64, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<Int64, TEnumerable, TEnumerator> enumerable, Int64 x)
            where TEnumerable : struct, IStructCollection<Int64, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Int64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Int64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<Int64, TEnumerable, TEnumerator> enumerable, Int64 x,
            Func<TEnumerable, IRefStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Int64>
            where TEnumerable : struct, IRefStructEnumerable<Int64, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<Int64, TEnumerable, TEnumerator> enumerable, Int64 x)
            where TEnumerable : struct, IRefStructEnumerable<Int64, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<Int64>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<Int64, TEnumerable, TEnumerator> enumerable, Int64 x,
            Func<TEnumerable, IRefStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<Int64>
            where TEnumerable : struct, IRefStructCollection<Int64, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<Int64, TEnumerable, TEnumerator> enumerable, Int64 x)
            where TEnumerable : struct, IRefStructCollection<Int64, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<Int64>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<UInt16, TEnumerable, TEnumerator> enumerable, UInt16 x,
            Func<TEnumerable, IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<UInt16, TEnumerable, TEnumerator> enumerable, UInt16 x)
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<UInt16, TEnumerable, TEnumerator> enumerable, UInt16 x,
            Func<TEnumerable, IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt16, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<UInt16, TEnumerable, TEnumerator> enumerable, UInt16 x)
            where TEnumerable : struct, IStructCollection<UInt16, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt16>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt16, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<UInt16, TEnumerable, TEnumerator> enumerable, UInt16 x,
            Func<TEnumerable, IRefStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
            where TEnumerable : struct, IRefStructEnumerable<UInt16, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<UInt16, TEnumerable, TEnumerator> enumerable, UInt16 x)
            where TEnumerable : struct, IRefStructEnumerable<UInt16, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<UInt16>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<UInt16, TEnumerable, TEnumerator> enumerable, UInt16 x,
            Func<TEnumerable, IRefStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<UInt16>
            where TEnumerable : struct, IRefStructCollection<UInt16, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<UInt16, TEnumerable, TEnumerator> enumerable, UInt16 x)
            where TEnumerable : struct, IRefStructCollection<UInt16, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<UInt16>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<UInt32, TEnumerable, TEnumerator> enumerable, UInt32 x,
            Func<TEnumerable, IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<UInt32, TEnumerable, TEnumerator> enumerable, UInt32 x)
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<UInt32, TEnumerable, TEnumerator> enumerable, UInt32 x,
            Func<TEnumerable, IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt32, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<UInt32, TEnumerable, TEnumerator> enumerable, UInt32 x)
            where TEnumerable : struct, IStructCollection<UInt32, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt32>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt32, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<UInt32, TEnumerable, TEnumerator> enumerable, UInt32 x,
            Func<TEnumerable, IRefStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
            where TEnumerable : struct, IRefStructEnumerable<UInt32, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<UInt32, TEnumerable, TEnumerator> enumerable, UInt32 x)
            where TEnumerable : struct, IRefStructEnumerable<UInt32, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<UInt32>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<UInt32, TEnumerable, TEnumerator> enumerable, UInt32 x,
            Func<TEnumerable, IRefStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<UInt32>
            where TEnumerable : struct, IRefStructCollection<UInt32, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<UInt32, TEnumerable, TEnumerator> enumerable, UInt32 x)
            where TEnumerable : struct, IRefStructCollection<UInt32, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<UInt32>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<UInt64, TEnumerable, TEnumerator> enumerable, UInt64 x,
            Func<TEnumerable, IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<UInt64, TEnumerable, TEnumerator> enumerable, UInt64 x)
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<UInt64, TEnumerable, TEnumerator> enumerable, UInt64 x,
            Func<TEnumerable, IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<UInt64, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<UInt64, TEnumerable, TEnumerator> enumerable, UInt64 x)
            where TEnumerable : struct, IStructCollection<UInt64, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<UInt64>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<UInt64, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<UInt64, TEnumerable, TEnumerator> enumerable, UInt64 x,
            Func<TEnumerable, IRefStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
            where TEnumerable : struct, IRefStructEnumerable<UInt64, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<UInt64, TEnumerable, TEnumerator> enumerable, UInt64 x)
            where TEnumerable : struct, IRefStructEnumerable<UInt64, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<UInt64>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<UInt64, TEnumerable, TEnumerator> enumerable, UInt64 x,
            Func<TEnumerable, IRefStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<UInt64>
            where TEnumerable : struct, IRefStructCollection<UInt64, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<UInt64, TEnumerable, TEnumerator> enumerable, UInt64 x)
            where TEnumerable : struct, IRefStructCollection<UInt64, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<UInt64>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<Single, TEnumerable, TEnumerator> enumerable, Single x,
            Func<TEnumerable, IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Single, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<Single, TEnumerable, TEnumerator> enumerable, Single x)
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Single, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<Single, TEnumerable, TEnumerator> enumerable, Single x,
            Func<TEnumerable, IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Single, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Single, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<Single, TEnumerable, TEnumerator> enumerable, Single x)
            where TEnumerable : struct, IStructCollection<Single, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Single>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Single, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<Single, TEnumerable, TEnumerator> enumerable, Single x,
            Func<TEnumerable, IRefStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Single>
            where TEnumerable : struct, IRefStructEnumerable<Single, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<Single, TEnumerable, TEnumerator> enumerable, Single x)
            where TEnumerable : struct, IRefStructEnumerable<Single, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<Single>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<Single, TEnumerable, TEnumerator> enumerable, Single x,
            Func<TEnumerable, IRefStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<Single>
            where TEnumerable : struct, IRefStructCollection<Single, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<Single, TEnumerable, TEnumerator> enumerable, Single x)
            where TEnumerable : struct, IRefStructCollection<Single, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<Single>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<Double, TEnumerable, TEnumerator> enumerable, Double x,
            Func<TEnumerable, IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Double, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<Double, TEnumerable, TEnumerator> enumerable, Double x)
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Double, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<Double, TEnumerable, TEnumerator> enumerable, Double x,
            Func<TEnumerable, IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Double, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Double, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<Double, TEnumerable, TEnumerator> enumerable, Double x)
            where TEnumerable : struct, IStructCollection<Double, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Double>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Double, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<Double, TEnumerable, TEnumerator> enumerable, Double x,
            Func<TEnumerable, IRefStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Double>
            where TEnumerable : struct, IRefStructEnumerable<Double, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<Double, TEnumerable, TEnumerator> enumerable, Double x)
            where TEnumerable : struct, IRefStructEnumerable<Double, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<Double>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<Double, TEnumerable, TEnumerator> enumerable, Double x,
            Func<TEnumerable, IRefStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<Double>
            where TEnumerable : struct, IRefStructCollection<Double, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<Double, TEnumerable, TEnumerator> enumerable, Double x)
            where TEnumerable : struct, IRefStructCollection<Double, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<Double>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<Byte, TEnumerable, TEnumerator> enumerable, Byte x,
            Func<TEnumerable, IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Byte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<Byte, TEnumerable, TEnumerator> enumerable, Byte x)
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Byte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<Byte, TEnumerable, TEnumerator> enumerable, Byte x,
            Func<TEnumerable, IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<Byte, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Byte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<Byte, TEnumerable, TEnumerator> enumerable, Byte x)
            where TEnumerable : struct, IStructCollection<Byte, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<Byte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<Byte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<Byte, TEnumerable, TEnumerator> enumerable, Byte x,
            Func<TEnumerable, IRefStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<Byte>
            where TEnumerable : struct, IRefStructEnumerable<Byte, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<Byte, TEnumerable, TEnumerator> enumerable, Byte x)
            where TEnumerable : struct, IRefStructEnumerable<Byte, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<Byte>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<Byte, TEnumerable, TEnumerator> enumerable, Byte x,
            Func<TEnumerable, IRefStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<Byte>
            where TEnumerable : struct, IRefStructCollection<Byte, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<Byte, TEnumerable, TEnumerator> enumerable, Byte x)
            where TEnumerable : struct, IRefStructCollection<Byte, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<Byte>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<SByte, TEnumerable, TEnumerator> enumerable, SByte x,
            Func<TEnumerable, IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<SByte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<SByte, TEnumerable, TEnumerator> enumerable, SByte x)
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<SByte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<SByte, TEnumerable, TEnumerator> enumerable, SByte x,
            Func<TEnumerable, IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<SByte, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<SByte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<SByte, TEnumerable, TEnumerator> enumerable, SByte x)
            where TEnumerable : struct, IStructCollection<SByte, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<SByte>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<SByte, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<SByte, TEnumerable, TEnumerator> enumerable, SByte x,
            Func<TEnumerable, IRefStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<SByte>
            where TEnumerable : struct, IRefStructEnumerable<SByte, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<SByte, TEnumerable, TEnumerator> enumerable, SByte x)
            where TEnumerable : struct, IRefStructEnumerable<SByte, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<SByte>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<SByte, TEnumerable, TEnumerator> enumerable, SByte x,
            Func<TEnumerable, IRefStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<SByte>
            where TEnumerable : struct, IRefStructCollection<SByte, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<SByte, TEnumerable, TEnumerator> enumerable, SByte x)
            where TEnumerable : struct, IRefStructCollection<SByte, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<SByte>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

            
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructEnumerable<DateTime, TEnumerable, TEnumerator> enumerable, DateTime x,
            Func<TEnumerable, IStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<DateTime, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<DateTime>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<DateTime, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructEnumerable<DateTime, TEnumerable, TEnumerator> enumerable, DateTime x)
            where TEnumerable : struct, IStructEnumerable<DateTime, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<DateTime>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<DateTime, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this StructCollection<DateTime, TEnumerable, TEnumerator> enumerable, DateTime x,
            Func<TEnumerable, IStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerable : struct, IStructCollection<DateTime, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<DateTime, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this StructCollection<DateTime, TEnumerable, TEnumerator> enumerable, DateTime x)
            where TEnumerable : struct, IStructCollection<DateTime, TEnumerator>
            where TEnumerator : struct, ICollectionEnumerator<DateTime>
        {
            var comparer = new DefaultStructEqualityComparer();
            var visitor = new ContainsVisitor<DateTime, DefaultStructEqualityComparer>(comparer, x);
            return enumerable.Visit(ref visitor) == VisitStatus.VisitorFinished;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructEnumerable<DateTime, TEnumerable, TEnumerator> enumerable, DateTime x,
            Func<TEnumerable, IRefStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerator : struct, IRefStructEnumerator<DateTime>
            where TEnumerable : struct, IRefStructEnumerable<DateTime, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructEnumerable<DateTime, TEnumerable, TEnumerator> enumerable, DateTime x)
            where TEnumerable : struct, IRefStructEnumerable<DateTime, TEnumerator>
            where TEnumerator : struct, IRefStructEnumerator<DateTime>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [Obsolete("Remove last argument")]
        public static bool Contains<TEnumerable, TEnumerator>(this RefStructCollection<DateTime, TEnumerable, TEnumerator> enumerable, DateTime x,
            Func<TEnumerable, IRefStructEnumerable<DateTime, TEnumerator>> _)
            where TEnumerator : struct, IRefCollectionEnumerator<DateTime>
            where TEnumerable : struct, IRefStructCollection<DateTime, TEnumerator>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Contains<TEnumerable, TEnumerator>(
            this RefStructCollection<DateTime, TEnumerable, TEnumerator> enumerable, DateTime x)
            where TEnumerable : struct, IRefStructCollection<DateTime, TEnumerator>
            where TEnumerator : struct, IRefCollectionEnumerator<DateTime>
        {
            var comparer = new DefaultStructInEqualityComparer();
            return enumerable.Contains(x, comparer);
        }

    
    }
}
