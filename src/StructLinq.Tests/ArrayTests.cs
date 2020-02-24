using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Xunit;

namespace StructLinq.Tests
{
    public class ArrayTests : AbstractEnumerableTests<int>
    {
        [Fact]
        public void ShouldSameAsSystem()
        {
            var sysArray = Enumerable.Range(0, 50).ToArray();
            var structArray = Enumerable.Range(0, 50).ToArray().ToTypedEnumerable().ToArray();
            Assert.Equal(sysArray, structArray);
        }

        protected override IEnumerable<int> Build(int size)
        {
            return Enumerable.Range(-1, size).ToArray().ToTypedEnumerable();
        }

        [Fact]
        public void Test()
        {
            var count = 10;
            var array = Enumerable.Range(0, count).Select(x => new Container(x)).ToArray();
            var intPtrs = Unsafe.As<Container[], IntPtr[]>(ref array);
            var sum = 0;
            for (int i = 0; i < intPtrs.Length; i++)
            {
                var c = Unsafe.As<IntPtr, Container>(ref intPtrs[i]);
                sum += c.element;
            }

            var expected = (count-1) * (count) / 2;
            Assert.Equal(expected, sum);
        }

        private class Container
        {
            public readonly int element;
            public Container(int element)
            {
                this.element = element;
            }
        }
    }
}