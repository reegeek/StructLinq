using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using ObjectLayoutInspector;
using StructLinq.BCL.Hashset;
using StructLinq.BCL.List;
using Xunit;

namespace StructLinq.BCL.Tests
{
    public class HashsetLayoutTests
    {
        [Fact]
        public void PrintLayout()
        {
            TypeLayout.PrintLayout<HashSet<int>>();
            TypeLayout.PrintLayout<HashsetLayout<int>>();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void ShouldMatchArrayOfInt(int size)
        {
            var hashSet = Enumerable.Range(-1, size).ToHashSet();
            var layout = Unsafe.As<HashSet<int>, HashsetLayout<int>>(ref hashSet);
            var list = hashSet.ToList();
            var typeLayout = TypeLayout.GetLayout(hashSet.GetType());
            var layoutLayout = TypeLayout.GetLayout<HashsetLayout<int>>();
            for (int i = 0; i < size; i++)
            {
                layout.Entries[i].Value.Should().Be(list[i], typeLayout.ToString() + layoutLayout);
            }
        }


    }
}
