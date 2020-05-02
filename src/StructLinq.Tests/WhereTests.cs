using System;
using System.Linq;
using StructLinq.Array;
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

    public class RefWhereTests : AbstractRefEnumerableTests<int,
        RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>,
        RefWhereEnumerator<int, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>>>
    {
        protected override RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>> Build(int size)
        {
            RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>> whereEnumerable = Enumerable.Range(-1, size)
                .ToArray()
                .ToRefStructEnumerable()
                .Where((in int x) => x >= -1, x => x);
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
                .Where(selector, x => x)
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
                .Where(ref whereFunc, x => x)
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

        struct InWhereFunc : IInFunction<int, bool>
        {
            public bool Eval(in int element)
            {
                return element > 0;
            }
        }

    }

}