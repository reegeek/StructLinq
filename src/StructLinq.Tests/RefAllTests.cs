﻿using FluentAssertions;
using StructLinq.Array;
using StructLinq.Where;
using Xunit;

namespace StructLinq.Tests
{
    public class RefAllTests
    {
        private static RefWhereEnumerable<int, ArrayRefEnumerable<int>, ArrayRefStructEnumerator<int>, StructInFunction<int, bool>> Enumerable()
        {
            return StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().Where((in int x) => true, _ => _);
        }

        [Fact]
        public void ShouldBeTrueWithFunc()
        {
            Enumerable().All(x => x < 11).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFunc()
        {
            Enumerable().All(x => x > 5).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueWithFuncZeroAlloc()
        {
            Enumerable().All(x => x < 11, x=> x).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFuncZeroAlloc()
        {
            Enumerable().All(x => x > 5, x=> x).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeFalseWithIFunctionZeroAlloc()
        {
            var func = new AllFunction(5);
            Enumerable().All(ref func, x => x).Should().BeFalse();
        }

        private struct AllFunction : IInFunction<int, bool>
        {
            private readonly int limit;
            public AllFunction(int limit)
            {
                this.limit = limit;
            }
            public bool Eval(in int element)
            {
                return element > limit;
            }
        }

        [Fact]
        public void ShouldBeFalseWithIFunction()
        {
            var func = new AllFunction(5);
            Enumerable().All(func).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueWithIFunction()
        {
            var func = new AllFunction(-1);
            Enumerable().All(func).Should().BeTrue();
        }

    }
}
