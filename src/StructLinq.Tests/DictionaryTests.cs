//using System.Collections.Generic;
//using System.Linq;
//using StructLinq.BCL.Dictionary;
//using Xunit;

//namespace StructLinq.Tests
//{
//    public class DictionaryTests : AbstractEnumerableTests<KeyValuePair<int, string>,
//        DictionaryEnumerable<int, string>,
//        DictionaryEnumerator<int, string>>
//    {
//        protected override DictionaryEnumerable<int, string> Build(int size)
//        {
//            return Enumerable
//                   .Range(-1, size)
//                   .ToDictionary(x => x, x => x.ToString())
//                   .ToStructEnumerable();
//        }

//        [Theory]
//        [InlineData(0)]
//        [InlineData(10)]
//        [InlineData(50)]
//        public void ShouldSameAsSystem(int size)
//        {
//            Dictionary<string, string> dictionary = Enumerable
//                                                    .Range(0, size)
//                                                    .ToDictionary(x => x.ToString(), x => x.ToString());
//            var sysArray = dictionary
//                           .AsEnumerable()
//                           .ToArray();
//            var structArray = Enumerable
//                              .Range(0, size)
//                              .ToDictionary(x => x.ToString(), x => x.ToString())
//                              .ToStructEnumerable()
//                              .ToEnumerable()
//                              .ToArray();
//            Assert.Equal(sysArray, structArray);
//        }

//        [Fact]
//        public void ShouldHandleAddElementAfterEnumerableWasCreated()
//        {
//            var dictionary = Enumerable.Range(0, 50).ToDictionary(x => x, x => x.ToString());
//            var structList = dictionary.ToStructEnumerable();
//            dictionary.Add(50, "50");

//            var expected = Enumerable.Range(0, 51)
//                                     .ToDictionary(x => x, x => x.ToString())
//                                     .AsEnumerable()
//                                     .ToArray();
//            var enumerable = structList.ToEnumerable().ToArray();
//            Assert.Equal(expected, enumerable);
//        }

//    }
//}
