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
            Assert.True(Program.IsLeapYear(8));
            Assert.True(Program.IsLeapYear(4));
            Assert.True(Program.IsLeapYear(0));
            Assert.False(Program.IsLeapYear(13));
            Assert.False(Program.IsLeapYear(18));
        }

        [Fact]
        public void TestDivisibleByHundred()
        {
            Assert.False(Program.IsLeapYear(200));
            Assert.False(Program.IsLeapYear(100));
            Assert.True(Program.IsLeapYear(0));
            Assert.True(Program.IsLeapYear(16));
            Assert.False(Program.IsLeapYear(1005));
        }

        [Fact]
        public void TestDivisibleByFourhoundred()
        {
            Assert.True(Program.IsLeapYear(2000));
            Assert.True(Program.IsLeapYear(1600));
            Assert.False(Program.IsLeapYear(200));
            Assert.False(Program.IsLeapYear(1800));
        }
    }
}
