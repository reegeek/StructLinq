using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class AggregateTests
    {
        [Fact]
        public void DelegateTest()
        {
            var expected =
                Enumerable.Range(-5, 10)
                    .Aggregate(0, (accumulate, element) => accumulate + element);
            var actual = StructEnumerable.Range2(-5, 10)
                .Aggregate(0, (accumulate, element) => accumulate + element);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StructTest()
        {
            var expected =
                Enumerable.Range(-50, 100)
                    .Aggregate(0, (accumulate, element) => accumulate + element);
            var aggregation = new Aggregation();
            var actual = StructEnumerable.Range2(-50, 100)
                .Aggregate(0, ref aggregation);
            Assert.Equal(expected, actual);
        }


        struct Aggregation : IAggregation<int, int>
        {
            public Aggregation(int result)
            {
                Result = result;
            }
            public void Aggregate(int element)
            {
                Result = Result + element;
            }
            public int Result { get; set; }
        }
    }
}