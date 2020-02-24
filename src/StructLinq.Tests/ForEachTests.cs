using System;
using Xunit;

namespace StructLinq.Tests
{
    public class ForEachTests
    {
        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void StructTest(int start, int count)
        {
            var structEnum = StructEnumerable.Range(start, count);
            var countAction = new CountAction();
            structEnum.ForEach(ref countAction);
            Assert.Equal(count, countAction.Count);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void StructTestWithGenericConstraint(int start, int count)
        {
            var structEnum = StructEnumerable.Range(start, count);
            var countAction = new CountAction();
            structEnum.ForEach(ref countAction, x => x);
            Assert.Equal(count, countAction.Count);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void DelegateTest(int start, int count)
        {
            var structEnum = StructEnumerable.Range(start, count);
            int resultCount = 0;
            Action<int> action = delegate(int i) { resultCount++; };
            structEnum.ForEach(action);
            Assert.Equal(count, resultCount);
        }

        [Theory]
        [InlineData(0, 10)]
        [InlineData(-10, 20)]
        [InlineData(-20, 10)]
        public void DelegateTestWithGenericConstraint(int start, int count)
        {
            var structEnum = StructEnumerable.Range(start, count);
            int resultCount = 0;
            Action<int> action = delegate(int i) { resultCount++; };
            structEnum.ForEach(action, x=> x);
            Assert.Equal(count, resultCount);
        }
    }

    struct CountAction : IAction<int>
    {
        public int Count;
        public void Do(int element)
        {
            Count++;
        }
    }
}
