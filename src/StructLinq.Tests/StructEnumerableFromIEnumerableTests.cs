using System.Collections.Generic;
using System.Linq;
using StructLinq.IEnumerable;

namespace StructLinq.Tests
{
    public class StructEnumerableFromIEnumerableTests: AbstractEnumerableTests<int,
        StructEnumerableFromIEnumerable<int>,
        GenericEnumerator<int>>
    {
        protected override StructEnumerableFromIEnumerable<int> Build(int size)
        {
            IEnumerable<int> enumerable = Enumerable.Range(0, size).ToArray();
            return enumerable.ToStructEnumerable();
        }
    }
}
