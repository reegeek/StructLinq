using System;
using Xunit;

namespace StructLinq.Tests.ForEach
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
        public void InterfaceTest(int start, int count)
        {
            var structEnum = StructEnumerable.Range(start, count);
            var countAction = new ClassAction();
            structEnum.ForEach(countAction);
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


        struct CountAction : IAction<int>
        {
            public int Count;
            public void Do(int element)
            {
                Count++;
            }
        }

        class ClassAction : IAction<int>
        {
            public int Count;
            public void Do(int element)
            {
                Count++;
            }
        }

    }
}
