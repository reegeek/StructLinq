// ReSharper disable InconsistentNaming
namespace StructLinq.BCL.List
{
#if (NET452 || NETCOREAPP1_0 || NETCOREAPP2_0 || NETCOREAPP2_2)
    
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

#if (NETCOREAPP3_0 || NET5_0)
    
    internal class ListLayout<T>
    {
        internal T[] Items;
        internal int Size;
    }
#endif

}