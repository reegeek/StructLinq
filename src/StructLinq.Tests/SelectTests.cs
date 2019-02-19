using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectTests
    {
        [Fact]
        public void DelegateTest()
        {
            Func<int, double> selector = x => x * 2.0;
            var sys = Enumerable
                .Range(-50, 100)
                .Select(selector)
                .ToArray();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Select(selector)
                .ToArray();
            Assert.Equal(sys, structEnum);
        }

        [Fact]
        public void StructTest()
        {
            Func<int, double> selector = x => x * 2.0;
            var sys = Enumerable
                .Range(-50, 100)
                .Select(selector)
                .ToArray();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Select(new StructInterface())
                .ToArray();
            Assert.Equal(sys, structEnum);

        }


        class TestInterface : IFunction<int, double>
        {
            public double Eval(int element)
            {
                return element * 2.0;
            }
        }

        class StructInterface : IFunctionFactory<int, double, MultFunction>
        {
            public MultFunction Build()
            {
                return new MultFunction();
            }
        }

        struct MultFunction : IFunction<int, double>
        {
            public double Eval(int element)
            {
                return element * 2.0;
            }
        }
    }
}