using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class EmptyTests
    {
        [Fact]
        public void ShouldBeEmpty()
        {
            StructEnumerable.Empty<int>()
                            .ToArray()
                            .Should()
                            .BeEmpty();
        }
    }
}
