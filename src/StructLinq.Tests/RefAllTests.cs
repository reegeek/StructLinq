using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class RefAllTests
    {
        [Fact]
        public void ShouldBeTrueWithFunc()
        {
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().All(x => x < 11).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFunc()
        {
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().All(x => x > 5).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeTrueWithFuncZeroAlloc()
        {
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().All(x => x < 11, x=> x).Should().BeTrue();
        }

        [Fact]
        public void ShouldBeFalseWithFuncZeroAlloc()
        {
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().All(x => x > 5, x=> x).Should().BeFalse();
        }

        [Fact]
        public void ShouldBeFalseWithIFunctionZeroAlloc()
        {
            var func = new AllFunction();
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().All(ref func, x => x).Should().BeFalse();
        }

        private struct AllFunction : IInFunction<int, bool>
        {
            public bool Eval(in int element)
            {
                return element > 5;
            }
        }

        [Fact]
        public void ShouldBeFalseWithIFunction()
        {
            var func = new AllFunction();
            StructEnumerable.Range(0, 10).ToArray().ToRefStructEnumerable().All(func).Should().BeFalse();
        }

    }
}
