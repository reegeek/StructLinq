using FluentAssertions;
using Xunit;

namespace StructLinq.Tests
{
    public abstract class AbstractCollectionTests<T, TStructCollection, TEnumerator> 
        : AbstractEnumerableTests<T, TStructCollection, TEnumerator> 
        where TStructCollection : IStructCollection<T, TEnumerator>
        where TEnumerator : struct, IStructEnumerator<T>
    {
        [Theory]
        [InlineData(0)]
        [InlineData(5)]
        [InlineData(10)]
        public void ShouldCountEqual(int size)
        {
            //Arrange
            var enumerable = Build(size);

            //Act
            int enumSize = enumerable.Count();

            //Assert
            enumSize.Should().Be(size);
        }

    }
}
