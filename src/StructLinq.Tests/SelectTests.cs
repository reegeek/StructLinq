﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace StructLinq.Tests
{
    public class SelectTests : AbstractEnumerableTests<int>
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
            var fct = new MultFunction();
            var structEnum = StructEnumerable
                .Range(-50, 100)
                .Select(ref fct, x=>x, x => x)
                .ToArray();
            Assert.Equal(sys, structEnum);

        }

        protected override IEnumerable<int> Build(int size)
        {
            return StructEnumerable.Range(-1, size).Select(x => x * 2, x=>x);
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