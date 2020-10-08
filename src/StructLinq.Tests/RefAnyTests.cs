using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class RefAnyTests
    {
        [Fact]
        public void ShouldBeTrueWithFunc()
        {
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().Any(x => x > 5).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFunc()
        {
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().Any(x => x > 11).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueWithFuncZeroAlloc()
        {
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().Any(x => x > 5, x=> x).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFuncZeroAlloc()
        {
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().Any(x => x > 11, x=> x).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeFalseWithIFunctionZeroAlloc()
        {
            var func = new AllFunction();
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().Any(ref func, x => x).Should().BeFalse();
        }

        private struct AllFunction : IInFunction<int, bool>
        {
            public bool Eval(in int element)
            {
                return element > 11;
            }
        }

        [Fact]
        public void ShouldBeFalseWithIFunction()
        {
            var func = new AllFunction();
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().Any(func).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueForNonEmptyEnumerable()
        {
            var array = new int[] {1};
            array.ToRefStructEnumerable().Any().Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseForEmptyEnumerable()
        {
            var array = new int[0];
            array.ToRefStructEnumerable().Any().Should().BeFalse();
        }

    }
}
