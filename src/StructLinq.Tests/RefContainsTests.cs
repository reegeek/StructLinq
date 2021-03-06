﻿using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public class RefContainsTests
    {
        [Fact]
        public void ShouldReturnTrue()
        {
            var enumerable = StructEnumerable.Range(0, 100).ToArray().ToRefStructEnumerable();
            for (int i = 0; i < 100; i++)
            {
                enumerable.Contains(i, x => x).Should().BeTrue();
            }
        }

        [Fact]
        public void ShouldReturnFalse()
        {
            var enumerable = StructEnumerable.Range(0, 100).ToArray().ToRefStructEnumerable();
            enumerable.Contains(-10, x => x).Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnFalseWithInterface()
        {
            var enumerable = StructEnumerable.Range(0, 100).ToArray().ToRefStructEnumerable();
            enumerable.Contains(-10).Should().BeFalse();
        }

        [Fact]
        public void ShouldReturnTrueWithInterface()
        {
            var enumerable = StructEnumerable.Range(0, 100).ToArray().ToRefStructEnumerable();
            for (int i = 0; i < 100; i++)
            {
                enumerable.Contains(i).Should().BeTrue();
            }
        }
    }
}
