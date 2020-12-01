// ReSharper disable InconsistentNaming

using System;

namespace StructLinq.BCL.List
{

#if (NETCOREAPP3_0 || NETCOREAPP3_1)
    
    internal class ListLayout<T>
    {
        internal T[] Items;
#pragma warning disable 169
        internal int Size;
#pragma warning restore 169
    }
#else
    internal class ListLayout<T>
    {
        internal T[] Items;
#pragma warning disable 169
        internal int Size;
        private int Version;
        private object SyncRoot;
#pragma warning restore 169
    }
	
#endif

}