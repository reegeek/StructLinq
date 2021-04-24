#if !NETSTANDARD1_1
namespace StructLinq.Hashset
{
    internal class HashsetLayout<T>
    {
        internal int[] Buckets;
        internal Slot<T>[] Entries;
        internal object Object1;
        internal object Object2;
    }

    internal struct Slot<T>
    {
        internal int HashCode;
        internal int Next;
        internal T Value;
    }

}
#endif