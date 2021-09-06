using System;
using Xunit;
using LeapYear;
using System.IO;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestDivisibleByFour()
        {
            Assert.True(Program.IsLeapYear(1604));
            Assert.False(Program.IsLeapYear(1700));
            Assert.False(Program.IsLeapYear(1800));
        }

        [Fact]
        public void TestDivisibleByHundred()
        {
            Assert.True(Program.IsLeapYear(4000));
            Assert.False(Program.IsLeapYear(1905));
        }

        [Fact]
        public void TestDivisibleByFourhoundred()
        {
            Assert.True(Program.IsLeapYear(2000));
            Assert.True(Program.IsLeapYear(1600));
            Assert.False(Program.IsLeapYear(1800));
        }

        [Fact]
        public void TestUserArgument()
        {
            Assert.Throws<ArgumentException>(() => Program.IsLeapYear(100));
            Assert.Throws<ArgumentException>(() => Program.IsLeapYear(0));
            Assert.Throws<ArgumentException>(() => Program.IsLeapYear(-400));
        }

        [Fact]
        public void TestMainPrintsYay()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var stdIn = new StringReader("2000\r\n");
            Console.SetIn(stdIn);
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
    
            Assert.Equal("Type in a year\nyay", output);
        }

        [Fact]
        public void TestMainPrintsNay()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            var stdIn = new StringReader("1999\r\n");
            Console.SetIn(stdIn);
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();
    
            Assert.Equal("Type in a year\nnay", output);
        }
    }
}
