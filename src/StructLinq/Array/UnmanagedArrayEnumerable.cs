namespace StructLinq.Array
{
    class UnmanagedArrayEnumerable<T> : AbstractTypedEnumerable<T, UnmanagedArrayEnumerator<T>> where T : unmanaged
    {
        private T[] array;
        public UnmanagedArrayEnumerable(ref T[] array)
        {
            this.array = array;
        }
        public override UnmanagedArrayEnumerator<T> GetTypedEnumerator()
        {
            return new UnmanagedArrayEnumerator<T>(ref array);
        }
    }
}