using System;
using Xunit;
using LeapYear;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestDivisibleByFour()
        {
            Assert.Equal(true, Program.IsLeapYear(8));
            Assert.Equal(true, Program.IsLeapYear(4));
            Assert.Equal(true, Program.IsLeapYear(0));
            Assert.Equal(false, Program.IsLeapYear(13));
            Assert.Equal(false, Program.IsLeapYear(18));
        }
    }
}
