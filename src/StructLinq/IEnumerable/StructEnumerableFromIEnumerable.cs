using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.IEnumerable
{
    public readonly struct StructEnumerableFromIEnumerable<T> : IStructEnumerable<T, GenericEnumerator<T>>
    {
        #region private fields
        private readonly IEnumerable<T> inner;
        #endregion
        public StructEnumerableFromIEnumerable(IEnumerable<T> inner)
        {
            this.inner = inner;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public GenericEnumerator<T> GetEnumerator()
        {
            return new GenericEnumerator<T>(inner.GetEnumerator());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            foreach (var input in this)
            {
                if (!visitor.Visit(input))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }
    }
}
