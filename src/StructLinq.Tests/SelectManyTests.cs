using System;
using System.Collections.Generic;
using System.Linq;
using StructLinq.Array;
using StructLinq.IEnumerable;
using StructLinq.SelectMany;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectManyTests : AbstractEnumerableTests<int,
        SelectManyEnumerable<int[], IStructEnumerable<int[], ArrayStructEnumerator<int[]>>, ArrayStructEnumerator<int[]>, int, StructEnumerableFromIEnumerable<int>, GenericEnumerator<int>, FuncEnumerable<int[], int>>,
        SelectManyEnumerator<int[], ArrayStructEnumerator<int[]>, int, StructEnumerableFromIEnumerable<int>,
            GenericEnumerator<int>, FuncEnumerable<int[], int>>>
    {
        protected override SelectManyEnumerable<int[], IStructEnumerable<int[], ArrayStructEnumerator<int[]>>, ArrayStructEnumerator<int[]>, int, StructEnumerableFromIEnumerable<int>, GenericEnumerator<int>, FuncEnumerable<int[], int>> Build(int size)
        {
            var n = 3;
            var blockSize = size / n;
            var list = new List<int[]>();
            var currentBlockSize = blockSize;
            var currentGlobalSize = 0;
            for (int i = 0; i < n; i++)
            {
                if (currentBlockSize == 0)
                    break;
                list.Add(Enumerable.Range(0, currentBlockSize).ToArray());
                currentGlobalSize += currentBlockSize;
                currentBlockSize = Math.Min(blockSize, size - currentGlobalSize);
            }

            if (list.Count == 0)
                list.Add(Enumerable.Range(0, size).ToArray());
            else
            {
                if (currentGlobalSize != size)
                    list.Add(Enumerable.Range(0, size - currentGlobalSize).ToArray());
            }

            return list.ToArray().ToStructEnumerable().SelectMany(x => x);
        }


        [Theory]
        [InlineData(0, 0)]
        [InlineData(20, 3)]
        [InlineData(10, 2)]
        [InlineData(10, 11)]
        public void ShouldSameAsLinqToArray(int size, int blockSize)
        {
            var list = new List<int[]>();
            var currentBlockSize = blockSize;
            var currentGlobalSize = 0;
            var n = blockSize == 0 ? 0 : size / blockSize;
            for (int i = 0; i < n; i++)
            {
                if (currentBlockSize == 0)
                    break;
                list.Add(Enumerable.Range(0, currentBlockSize).ToArray());
                currentGlobalSize += currentBlockSize;
                currentBlockSize = Math.Min(blockSize, size - currentGlobalSize);
            }

            if (list.Count == 0)
                list.Add(Enumerable.Range(0, size).ToArray());

            var arrayOfArray = list.ToArray();

            var expected = arrayOfArray.SelectMany(x => x).ToArray();
            var values = arrayOfArray.ToStructEnumerable().SelectMany(x => x).ToArray();
            Assert.Equal(expected, values);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(20, 3)]
        [InlineData(10, 2)]
        [InlineData(10, 11)]
        public void ShouldSameAsLinq(int size, int blockSize)
        {
            var list = new List<int[]>();
            var currentBlockSize = blockSize;
            var currentGlobalSize = 0;
            var n = blockSize == 0 ? 0 : size / blockSize;
            for (int i = 0; i < n; i++)
            {
                if (currentBlockSize == 0)
                    break;
                list.Add(Enumerable.Range(0, currentBlockSize).ToArray());
                currentGlobalSize += currentBlockSize;
                currentBlockSize = Math.Min(blockSize, size - currentGlobalSize);
            }

            if (list.Count == 0)
                list.Add(Enumerable.Range(0, size).ToArray());

            var arrayOfArray = list.ToArray();
            var expected = arrayOfArray.SelectMany(x => x).ToArray();
            var listValues = new List<int>();
            foreach (var i in arrayOfArray.ToStructEnumerable().SelectMany(x => x))
            {
                listValues.Add(i);
            }
            var values = listValues.ToArray();
            Assert.Equal(expected, values);
        }

        [Fact]
        public void ShouldIgnoreEmptyArray()
        {
            var list = new List<int[]>();
            list.Add(Enumerable.Range(0, 10).ToArray());
            list.Add(Enumerable.Range(0, 0).ToArray());
            list.Add(Enumerable.Range(-1, 10).ToArray());

            var arrayOfArray = list.ToArray();
            var expected = arrayOfArray.SelectMany(x => x).ToArray();
            var listValues = new List<int>();
            foreach (var i in arrayOfArray.ToStructEnumerable().SelectMany(x => x))
            {
                listValues.Add(i);
            }
            var values = listValues.ToArray();
            Assert.Equal(expected, values);
        }

    }
}