namespace StructLinq.Range
{
    class RangeEnumerable : AbstractTypedEnumerable<int, RangeEnumerator>
    {
        #region private fields
        private readonly int start;
        private readonly int count;
        #endregion
        public RangeEnumerable(int start, int count)
        {
            this.start = start;
            this.count = count;
        }
        public override RangeEnumerator GetTypedEnumerator()
        {
            return new RangeEnumerator(start, count);
        }
    }
}
