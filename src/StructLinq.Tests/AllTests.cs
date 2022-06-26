﻿using FluentAssertions;
using StructLinq.Range;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class AllTests
    {
        private static StructEnumerable<int, RangeEnumerable, RangeEnumerator> StructEnumerable()
        {
            return StructLinq.StructEnumerable.Range(0, 10).ToStructEnumerable();
        }

        [Fact]
        public void ShouldBeTrueWithFunc()
        {
            StructEnumerable().All(x => x < 11).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFunc()
        {
            StructEnumerable().All(x => x > 5).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueWithFuncZeroAlloc()
        {
            StructEnumerable().All(x => x < 11, x=> x).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFuncZeroAlloc()
        {
            StructEnumerable().All(x => x > 5, x=> x).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeFalseWithIFunctionZeroAlloc()
        {
            var func = new AllFunction(5);
            StructEnumerable().All(ref func, x => x).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueWithIFunctionZeroAlloc()
        {
            var func = new AllFunction(-1);
            StructEnumerable().All(ref func, x => x).Should().BeTrue();
        }

        private struct AllFunction : IFunction<int, bool>
        {
            private readonly int limit;
            public AllFunction(int limit)
            {
                this.limit = limit;
            }
            public bool Eval(int element)
            {
                return element > limit;
            }
        }

        [Fact]
        public void ShouldBeFalseWithIFunction()
        {
            var func = new AllFunction();
            StructEnumerable().All(ref func).Should().BeFalse();
        }
    }

}
