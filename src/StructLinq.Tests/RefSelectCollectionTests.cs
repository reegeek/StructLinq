using StructLinq.Array;
using StructLinq.Select;

namespace StructLinq.Tests
{
    public class RefSelectCollectionTests : AbstractCollectionTests<double,
        RefSelectCollection<int, double, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, RefSelectCollectionTests.MultFunction>,
        RefSelectEnumerator<int, double, ArrayRefStructEnumerator<int>, RefSelectCollectionTests.MultFunction>>
    {

        protected override RefSelectCollection<int, double, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, RefSelectCollectionTests.MultFunction> Build(int size)
        {
            var func = new MultFunction();
            var selectEnumerable = 
                StructEnumerable.Range(-1, size).ToArray().ToRefStructEnumerable().Select(ref func, x=>x, x => x);
            return selectEnumerable;
        }

        public struct MultFunction : IInFunction<int, double>
        {
            public double Eval(in int element)
            {
                return element * 2.0;
            }
        }
    }
}