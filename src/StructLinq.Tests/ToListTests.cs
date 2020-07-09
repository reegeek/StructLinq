using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class ToListTests
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var list = Enumerable.Range(-10, 50)
                                 .ToArray()
                                 .ToStructEnumerable()
                                 .ToList();
            Assert.Equal(list, Enumerable.Range(-10, 50).ToList());
        }

        [Fact]
        public void ShouldSameAsSystemForRef()
        {
            var list = Enumerable.Range(-10, 50)
                                 .ToArray()
                                 .ToRefStructEnumerable()
                                 .ToList();

            Assert.Equal(list, Enumerable.Range(-10, 50).ToList());
        }

    }
}
