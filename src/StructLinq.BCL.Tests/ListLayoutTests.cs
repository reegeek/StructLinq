﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using FluentAssertions;
using ObjectLayoutInspector;
using StructLinq.BCL.List;
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
            var layout = Unsafe.As<List<int>, ListLayout<int>>(ref list);
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
            var layout = Unsafe.As<List<int>, ListLayout<int>>(ref list);
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
            var layout = Unsafe.As<List<string>, ListLayout<string>>(ref list);
            for (int i = 0; i < size; i++)
            {
                layout.Items[i].Should().Be((i - 1).ToString());
            }
        }
    }

#if IS_X86
    public class BitnessTests
    {
        [Fact]
        public void Checkx86Bitness()
        {
            Assert.Equal(4, IntPtr.Size);
        }
    }
#endif

#if IS_X64
    public class BitnessTests
    {
        [Fact]
        public void Checkx64Bitness()
        {
            Assert.Equal(8, IntPtr.Size);
        }
    }
#endif

}
