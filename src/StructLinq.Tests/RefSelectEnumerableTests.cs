using StructLinq.Array;
using StructLinq.Select;

namespace StructLinq.Tests
{
    public class RefSelectEnumerableTests : AbstractEnumerableTests<double,
        RefSelectEnumerable<int, double, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, RefSelectEnumerableTests.MultFunction>,
        RefSelectEnumerator<int, double, ArrayRefStructEnumerator<int>, RefSelectEnumerableTests.MultFunction>>
    {

        protected override RefSelectEnumerable<int, double, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, RefSelectEnumerableTests.MultFunction> Build(int size)
        {
            var func = new RefSelectEnumerableTests.MultFunction();
            var selectEnumerable = 
                StructEnumerable.Range(-1, size).ToArray().ToRefStructEnumerable().Select(ref func, x=>(IRefStructEnumerable<int, ArrayRefStructEnumerator<int>>)x, x => x);
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
