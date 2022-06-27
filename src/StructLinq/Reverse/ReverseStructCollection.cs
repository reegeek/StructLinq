using System.Runtime.CompilerServices;
using StructLinq.Utils;

namespace StructLinq.Reverse
{
    public struct ReverseStructCollection<T, TStructCollection, TEnumerator> : IStructCollection<T, ReverseEnumerator<T, TEnumerator>> 
        where TStructCollection : IStructCollection<T, TEnumerator> 
        where TEnumerator : struct, ICollectionEnumerator<T>
    {
        private readonly TStructCollection structCollection;
        private int length;
        private int start;

        public ReverseStructCollection(TStructCollection structCollection, int start, int length)
        {
            this.structCollection = structCollection;
            this.start = start;
            this.length = length;
        }
        public readonly ReverseEnumerator<T, TEnumerator> GetEnumerator()
        {
            var inner = structCollection.GetEnumerator();
            return new ReverseEnumerator<T, TEnumerator>(inner, start, Count);
        }
        public readonly int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => MathHelpers.Max(0, length - start);
        }
        public void Slice(uint start, uint? length)
        {
            checked
            {
                this.start = (int)start + this.start;
                if (length.HasValue)
                    this.length = MathHelpers.Min((int)length.Value + this.start, this.length);
            }
        }
        public object Clone()
        {
            return this;
        }
        public readonly T Get(int i)
        {
            return structCollection.Get(structCollection.Count - 1 - start - i);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly VisitStatus Visit<TVisitor>(ref TVisitor visitor)
            where TVisitor : IVisitor<T>
        {
            var c = structCollection.Count;
            var s = start;
            var count = Count;
            for (int i = 0; i < count; i++)
            {
                var input = structCollection.Get(c - 1 - s - i);
                if (!visitor.Visit(input))
                    return VisitStatus.VisitorFinished;
            }

            return VisitStatus.EnumeratorFinished;
        }
    }
}