using System;
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
