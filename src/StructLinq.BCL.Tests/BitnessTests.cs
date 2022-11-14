using System;
using Xunit;

namespace StructLinq.BCL.Tests
{
#if IS_X86
    public class BitnessTests
    {
        [Fact]
        public void Checkx86Bitness()
        {
            Assert.Equal(4, IntPtr.Size);
        }
    }
#endif

#if IS_X64
    public class BitnessTests
    {
        [Fact]
        public void Checkx64Bitness()
        {
            Assert.Equal(8, IntPtr.Size);
        }
    }
#endif
}
