﻿using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using StructLinq.BCL.List;
using Xunit;

namespace StructLinq.BCL.Tests
{
    public class ListLayoutTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(10)]
        [InlineData(100)]
        public void ShouldCountMustBe(int size)
        {
#if !NETCOREAPP1_1 && !NETCOREAPP1_0
            Console.WriteLine($"Version: {Environment.Version}");
#endif
            var list = Enumerable.Range(-1, size).ToList();
            var layout = Unsafe.As<List<int>, ListLayout<int>>(ref list);
            layout.Size.Should().Be(size);
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
}
