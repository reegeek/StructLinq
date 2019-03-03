namespace StructLinq.Array
{
    class ArrayEnumerable<T> : AbstractTypedEnumerable<T, ArrayStructEnumerator<T>>
    {
        #region private fields
        private T[] array;
        #endregion
        public ArrayEnumerable(ref T[] array)
        {
            this.array = array;
        }
        public override ArrayStructEnumerator<T> GetTypedEnumerator()
        {
            return new ArrayStructEnumerator<T>(ref array);
        }
    }
}