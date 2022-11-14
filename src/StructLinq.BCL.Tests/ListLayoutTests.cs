using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using ObjectLayoutInspector;
using StructLinq.List;
using StructLinq.Utils;
using Xunit;

namespace StructLinq.BCL.Tests
{

    public class ListLayoutTests
    {
        [Fact]
        public void PrintLayout()
        {
            TypeLayout.PrintLayout<List<int>>();
            TypeLayout.PrintLayout<ListLayout<int>>();
        }

        [Fact]
        public void ItemsOffsetForInt()
        {
            var fieldOffsets = TypeInspector.GetFieldOffsets(typeof(List<int>));
            var layoutFieldOffsets = TypeInspector.GetFieldOffsets(typeof(ListLayout<int>));

            var (_, offset) = fieldOffsets.Single(x=> x.fieldInfo.Name == "_items");
            var (_, layoutOffset) = layoutFieldOffsets.Single(x=> x.fieldInfo.Name == "Items");
            layoutOffset.Should().Be(offset);
        }

        [Fact]
        public void SizeOffsetForInt()
        {
            var fieldOffsets = TypeInspector.GetFieldOffsets(typeof(List<int>));
            var layoutFieldOffsets = TypeInspector.GetFieldOffsets(typeof(ListLayout<int>));

            var (_, offset) = fieldOffsets.Single(x=> x.fieldInfo.Name == "_size");
            var (_, layoutOffset) = layoutFieldOffsets.Single(x=> x.fieldInfo.Name == "Size");
            layoutOffset.Should().Be(offset);
        }

        [Fact]
        public void ItemsOffsetForString()
        {
            var fieldOffsets = TypeInspector.GetFieldOffsets(typeof(List<string>));
            var layoutFieldOffsets = TypeInspector.GetFieldOffsets(typeof(ListLayout<string>));

            var (_, offset) = fieldOffsets.Single(x=> x.fieldInfo.Name == "_items");
            var (_, layoutOffset) = layoutFieldOffsets.Single(x=> x.fieldInfo.Name == "Items");
            layoutOffset.Should().Be(offset);
        }

        [Fact]
        public void SizeOffsetForString()
        {
            var fieldOffsets = TypeInspector.GetFieldOffsets(typeof(List<string>));
            var layoutFieldOffsets = TypeInspector.GetFieldOffsets(typeof(ListLayout<string>));

            var (_, offset) = fieldOffsets.Single(x=> x.fieldInfo.Name == "_size");
            var (_, layoutOffset) = layoutFieldOffsets.Single(x=> x.fieldInfo.Name == "Size");
            layoutOffset.Should().Be(offset);
        }


        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void ShouldCountMustBe(int size)
        {
            var list = Enumerable.Range(-1, size).ToList();
            var layout = UnsafeHelpers.As<List<int>, ListLayout<int>>(ref list);
            var typeLayout = TypeLayout.GetLayout(list.GetType());
            var layoutLayout = TypeLayout.GetLayout<ListLayout<int>>();
            layout.Size.Should().Be(size, typeLayout.ToString() + layoutLayout);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void ShouldMatchArrayOfInt(int size)
        {
            var list = Enumerable.Range(-1, size).ToList();
            var layout = UnsafeHelpers.As<List<int>, ListLayout<int>>(ref list);
            for (int i = 0; i < size; i++)
            {
                layout.Items[i].Should().Be(i - 1);
            }
        }

        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void ShouldMatchArrayOfString(int size)
        {
            var list = Enumerable.Range(-1, size).Select(x=> x.ToString()).ToList();
            var layout = UnsafeHelpers.As<List<string>, ListLayout<string>>(ref list);
            for (int i = 0; i < size; i++)
            {
                layout.Items[i].Should().Be((i - 1).ToString());
            }
        }
    }

}
