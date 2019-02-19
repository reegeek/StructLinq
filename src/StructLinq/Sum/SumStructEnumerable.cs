using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace StructLinq
{
    public static partial class StructEnumerable
    {
        #region private fields
        private static int Sum<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : IEnumerator<int>
        {
            int result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        #endregion
        public static int Sum<TEnumerator>(this ITypedEnumerable<int, TEnumerator> enumerable)
            where TEnumerator : IEnumerator<int>
        {
            using (var enumerator = enumerable.GetTypedEnumerator())
            {
                return Sum(enumerator);
            }
        }
    }
}
