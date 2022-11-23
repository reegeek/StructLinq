﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq.IEnumerable
{
    public readonly struct GenericEnumerator<T> : IStructEnumerator<T>
    {
        #region private fields
        private readonly IEnumerator<T> inner;
        #endregion
        public GenericEnumerator(IEnumerator<T> inner)
        {
            this.inner = inner;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return inner.MoveNext();
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            inner.Reset();
        }
        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => inner.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Dispose()
        {
            inner.Dispose();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public GenericEnumerator<T> GetEnumerator() => this;

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