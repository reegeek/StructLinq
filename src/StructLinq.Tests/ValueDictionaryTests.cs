//using System.Linq;
//using StructLinq.BCL.Dictionary;
//using Xunit;

//namespace StructLinq.Tests
//{
//    public class ValueDictionaryTests : AbstractEnumerableTests<string,
//        DictionaryValueEnumerable<int, string>,
//        DictionaryValueEnumerator<int, string>>
//    {
//        protected override DictionaryValueEnumerable<int, string> Build(int size)
//        {
//            return Enumerable
//                   .Range(-1, size)
//                   .ToDictionary(x => x, x => x.ToString())
//                   .ToStructValueEnumerable();
//        }

//        [Theory]
//        [InlineData(0)]
//        [InlineData(10)]
//        [InlineData(50)]
//        public void ShouldSameAsSystem(int size)
//        {
//            var sysArray = Enumerable
//                           .Range(0, size)
//                           .ToDictionary(x => x.ToString(), x => x.ToString())
//                           .Values
//                           .AsEnumerable()
//                           .ToArray();
//            var structArray = Enumerable
//                              .Range(0, size)
//                              .ToDictionary(x => x.ToString(), x => x.ToString())
//                              .ToStructValueEnumerable()
//                              .ToEnumerable()
//                              .ToArray();
//            Assert.Equal(sysArray, structArray);
//        }

//        [Fact]
//        public void ShouldHandleAddElementAfterEnumerableWasCreated()
//        {
//            var dictionary = Enumerable.Range(0, 50).ToDictionary(x => x, x => x.ToString());
//            var structValueEnumerable = dictionary.ToStructValueEnumerable();
//            dictionary.Add(50, "50");

//            var expected = Enumerable.Range(0, 51)
//                                     .ToDictionary(x => x, x => x.ToString())
//                                     .Values
//                                     .AsEnumerable()
//                                     .ToArray();
//            var enumerable = structValueEnumerable.ToEnumerable().ToArray();
//            Assert.Equal(expected, enumerable);
//        }
//    }
//}
