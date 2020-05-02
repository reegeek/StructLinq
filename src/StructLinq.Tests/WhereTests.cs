using System;
using System.Linq;
using StructLinq.Range;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class WhereTests : AbstractEnumerableTests<int,
        WhereEnumerable<int, RangeEnumerable, RangeEnumerator, StructFunction<int, bool>>,
        WhereEnumerator<int, RangeEnumerator, StructFunction<int, bool>>>
    {
        protected override WhereEnumerable<int, RangeEnumerable, RangeEnumerator, StructFunction<int, bool>> Build(int size)
        {
            var whereEnumerable = StructEnumerable.Range(-1, size).Where(x => x >= -1, x=>x);
            return whereEnumerable;
        }

        [Fact]
        public void DelegateTest()
        {
            Func<int, bool> selector = x => x > 0;
            var sys = Enumerable
                .Range(-50, 100)
                .Where(selector)
                .ToArray();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Where(selector, x=>x)
                .ToEnumerable()
                .ToArray();
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void StructTest()
        {
            Func<int, bool> selector = x => x>0;
            var sys = Enumerable
                .Range(-50, 100)
                .Where(selector)
                .ToArray();
            var whereFunc = new WhereFunc();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Where(ref whereFunc, x=>x)
                .ToEnumerable()
                .ToArray();
            Assert.Equal(sys, structEnum);

        }

        struct WhereFunc : IFunction<int, bool>
        {
            public bool Eval(int element)
            {
                return element > 0;
            }
        }
    }
}