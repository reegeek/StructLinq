// ReSharper disable InconsistentNaming
namespace StructLinq.BCL.List
{
#if (NETCOREAPP3_0 || NETCOREAPP3_1 || NET5_0)
    
    internal class ListLayout<T>
    {
        internal T[] Items;
        internal int Size;
    }
#else
    internal class ListLayout<T>
    {
        internal T[] Items;
        internal int Size;
#pragma warning disable 169
        private int Version;
        private object SyncRoot;
#pragma warning restore 169
    }
#endif

}