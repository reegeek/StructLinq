

// ReSharper disable once CheckNamespace

using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public partial struct RefStructEnum<T, TEnumerator>
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Count()
        {
            int count = 0;
            var copy = enumerator; 
            while (copy.MoveNext())
            {
                count++;
            }
            copy.Dispose();
            return count;
        }
    }
}
