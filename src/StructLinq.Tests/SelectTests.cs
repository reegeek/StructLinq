using System;
using System.Linq;
using StructLinq.Range;
using StructLinq.Select;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectTests : AbstractEnumerableTests<int,
        SelectEnumerable<int, int, RangeEnumerable, RangeEnumerator, StructFunction<int, int>>,
        SelectEnumerator<int, int, RangeEnumerator, StructFunction<int, int>>>
    {
        [Fact]
        public void DelegateTest()
        {
            Func<int, double> selector = x => x * 2.0;
            var sys = Enumerable
                .Range(-50, 100)
                .Select(selector)
                .ToArray();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Select(selector, x=>x)
                .ToEnumerable()
                .ToArray();
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void StructTest()
        {
            Func<int, double> selector = x => x * 2.0;
            var sys = Enumerable
                .Range(-50, 100)
                .Select(selector)
                .ToArray();
            var fct = new MultFunction();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Select(ref fct, x=>x, x => x)
                .ToEnumerable()
                .ToArray();
            Assert.Equal(sys, structEnum);

        }

        protected override SelectEnumerable<int, int, RangeEnumerable, RangeEnumerator, StructFunction<int, int>> Build(int size)
        {
            var selectEnumerable = StructEnumerable.Range(-1, size).Select(x => x * 2, x=>x);
            return selectEnumerable;
        }

        struct MultFunction : IFunction<int, double>
        {
            public double Eval(int element)
            {
                return element * 2.0;
            }
        }
    }
}