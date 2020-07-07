namespace StructLinq.BCL.List
{
#if (NET452 || NETCOREAPP1_0)
    
    internal class ListLayout<T>
    {
        internal T[] Items = default!;
        internal int Size;
        internal int Version;
        internal object? _syncRoot;
    }
#endif

#if (NETCOREAPP3_0)
    
    internal class ListLayout<T>
    {
        internal T[] Items = default!;
        internal int Size;
    }
#endif

}