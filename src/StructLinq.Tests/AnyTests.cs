using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class AnyTests
    {
        [Fact]
        public void ShouldBeTrueWithFunc()
        {
            StructEnumerable.Range2(0, 10).Any(x => x > 5).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFunc()
        {
            StructEnumerable.Range2(0, 10).Any(x => x > 11).Should().BeFalse();
        }

        private struct AllFunction : IFunction<int, bool>
        {
            public bool Eval(int element)
            {
                return element > 11;
            }
        }

        [Fact]
        public void ShouldBeFalseWithIFunction()
        {
            var func = new AllFunction();
            StructEnumerable.Range2(0, 10).Any(ref func).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueForNonEmptyEnumerable()
        {
            var array = new int[] {1};
            array.ToStructEnum().Any().Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseForEmptyEnumerable()
        {
            var array = new int[0];
            array.ToStructEnum().Any().Should().BeFalse();
        }

    }
}
