using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class RefSumTests
    {
        [Fact]
        public void StructTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToArray()
                .ToRefStructEnumerable()
                .Sum();
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void StructWithContainerTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .Select(x => new Container { Int = x })
                .ToArray()
                .ToRefStructEnumerable()
                .Sum((in Container element) => element.Int);
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void StructWithContainerAndFunctionTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var func = new FunctionContainer();
            var structEnum = Enumerable
                .Range(-50, 100)
                .Select(x => new Container { Int = x })
                .ToArray()
                .ToRefStructEnumerable()
                .Sum(func);
            Assert.Equal(sys, structEnum);
        }


        [Fact]
        public void ZeroAllocStructTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToArray()
                .ToRefStructEnumerable()
                .Sum(x => x);
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void ZeroStructWithContainerTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .Select(x => new Container { Int = x })
                .ToArray()
                .ToRefStructEnumerable()
                .Sum((in Container element) => element.Int, x=>x);
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void ZeroStructWithContainerAndFunctionTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var func = new FunctionContainer();
            var structEnum = Enumerable
                .Range(-50, 100)
                .Select(x => new Container { Int = x })
                .ToArray()
                .ToRefStructEnumerable()
                .Sum(ref func, x=>x, x=>x);
            Assert.Equal(sys, structEnum);
        }


        private struct Container
        {
            public int Int { get; set; }
        }

        private struct FunctionContainer : IInFunction<Container, int>
        {
            public int Eval(in Container element)
            {
                return element.Int;
            }
        }

    }
}