using System;
//using MathTools;
using Xunit;

namespace MathTools.Tests
{
    public class ClampRangeTest
    {
        [Fact]
        public void ClampRangeConstructorShouldParseTest()
        {
            ClampRange rangeIn = new ClampRange("0..10");
            
            Assert.Equal(0, rangeIn.A);
            Assert.Equal(10, rangeIn.B);            
        }
    }
}
