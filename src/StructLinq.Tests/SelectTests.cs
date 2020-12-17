using System;
using System.Linq;
using StructLinq.Range;
using StructLinq.Select;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectTests : AbstractEnumerableTests<double,
        SelectEnumerable<int, double, RangeEnumerable, RangeEnumerator, MultFunction>,
        SelectEnumerator<int, double, RangeEnumerator, MultFunction>>
    {
        [Fact]
        public void DelegateTest()
        {
            Func<int, double> selector = x => x * 2.0;
            var sys = Enumerable
                      .Range(-50, 100)
                      .Select(selector)
                      .ToArray();
            var func = new MultFunction();
            var structEnum = StructEnumerable
                             .Range(-50, 100)
                             .Select(ref func, x=>x, x=> x)
                             .ToEnumerable()
                             .ToArray();
            Assert.Equal(sys, structEnum);
        }

        protected override SelectEnumerable<int, double, RangeEnumerable, RangeEnumerator, MultFunction> Build(int size)
        {
            var func = new MultFunction();
            SelectEnumerable<int, double, RangeEnumerable, RangeEnumerator, MultFunction> selectEnumerable = 
                StructEnumerable.Range(-1, size).Select(ref func, x=>x, x => x);
            return selectEnumerable;
        }

    }
    
    public struct MultFunction : IFunction<int, double>
    {
        public double Eval(int element)
        {
            return element * 2.0;
        }
    }
}
