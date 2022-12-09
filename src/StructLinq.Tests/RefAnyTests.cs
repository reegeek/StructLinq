using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class RefAnyTests
    {
        [Fact]
        public void ShouldBeTrueWithFunc()
        {
            StructEnumerable.Range2(0, 10).ToArray().ToRefStructEnum().Any(x => x > 5).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFunc()
        {
            StructEnumerable.Range2(0, 10).ToArray().ToRefStructEnum().Any(x => x > 11).Should().BeFalse();
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
            StructEnumerable.Range2(0, 10).ToArray().ToRefStructEnumerable().Any(func).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueForNonEmptyEnumerable()
        {
            var array = new int[] {1};
            array.ToRefStructEnum().Any().Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseForEmptyEnumerable()
        {
            var array = new int[0];
            array.ToRefStructEnum().Any().Should().BeFalse();
        }

    }
}
