using System;
using Xunit;
using Logic_And_Settings;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            CalculateAvg ca = new CalculateAvg();

            ca.AddMarkAndPoints(90, 4);
            ca.SubstractMarkAndPoints(90,4);

            Assert.Equal("0", ca.ToString());
        }
    }
}
