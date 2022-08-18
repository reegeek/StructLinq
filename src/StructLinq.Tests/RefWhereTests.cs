using System;
using System.Linq;
using StructLinq.Array;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class RefWhereTests : AbstractRefEnumerableTests<int,
        RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>,
        RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>>
    {
        protected override RefStructEnumerable<int, RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>, RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>> Build(int size)
        {
            var whereEnumerable = Enumerable.Range(-1, size)
                    .ToArray()
                    .ToRefStructEnumerable()
                    .Where((in int x) => x >= -1);
            return whereEnumerable;
        }

        [Fact]
        public void DelegateTest()
        {
            InFunc<int, bool> selector = (in int x) => x > 0;
            var sys = Enumerable
                .Range(-50, 100)
                .Where(x => x > 0)
                .ToArray();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToArray()
                .ToRefStructEnumerable()
                .Where(selector)
                .ToEnumerable()
                .ToArray();
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void StructTest()
        {
            Func<int, bool> selector = x => x > 0;
            var sys = Enumerable
                .Range(-50, 100)
                .Where(selector)
                .ToArray();
            var whereFunc = new InWhereFunc();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToArray()
                .ToRefStructEnumerable()
                .Where(ref whereFunc)
                .ToEnumerable()
                .ToArray();
            Assert.Equal(sys, structEnum);

        }

        struct InWhereFunc : IInFunction<int, bool>
        {
            public bool Eval(in int element)
            {
                return element > 0;
            }
        }

    }
}