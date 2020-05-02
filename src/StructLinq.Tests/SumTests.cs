using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Xunit;

namespace StructLinq.Tests
{
    public class SumTests
    {
        [Fact]
        public void StructTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = StructEnumerable
                .Range(-50, 100)
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
                .Select(x=> new Container {Int = x})
                .ToStructEnumerable()
                .Sum(x=> x.Int);
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
                .ToStructEnumerable()
                .Sum(func);
            Assert.Equal(sys, structEnum);
        }


        [Fact]
        public void ZeroAllocStructTest()
        {
            var sys = Enumerable
                      .Range(-50, 100)
                      .Sum();
            var structEnum = StructEnumerable
                             .Range(-50, 100)
                             .Sum(x=> x);
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void ZeroAllocStructWithContainerTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .Select(x => new Container { Int = x })
                .ToStructEnumerable()
                .Sum(x => x.Int, x => x);
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void ZeroAllocStructWithContainerAndFunctionTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var func = new FunctionContainer();
            var structEnum = Enumerable
                .Range(-50, 100)
                .Select(x => new Container { Int = x })
                .ToStructEnumerable()
                .Sum(ref func, x=> x, x=> x);
            Assert.Equal(sys, structEnum);
        }


        [Fact]
        public void ConvertTest()
        {
            var sys = Enumerable
                .Range(-50, 100)
                .Sum();
            var structEnum = Enumerable
                .Range(-50, 100)
                .ToStructEnumerable()
                .Sum();
            Assert.Equal(sys, structEnum);
        }

        private class Container
        {
            public int Int { get; set; }
        }

        private class FunctionContainer : IFunction<Container, int>
        {
            public int Eval(Container element)
            {
                return element.Int;
            }
        }
    }
}