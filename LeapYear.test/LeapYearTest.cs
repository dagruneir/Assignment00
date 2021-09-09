using System;
using System.IO;
using Xunit;

namespace Assignment00.test
{
    public class LeapYearTest
    {
        LeapYear ly = new LeapYear();

        [Fact]
        public void LeapYearDividedBy4()
        { 
            var returnTrue = ly.IsLeapYear(4);
            Assert.True(returnTrue);

            var returnFalse = ly.IsLeapYear(5);
            Assert.False(returnFalse);
        }

        [Fact]
        public void LeapYearDividedBy100()
        {
            var returnTrue = ly.IsLeapYear(1600);
            Assert.True(returnTrue);

            var returnFalse = ly.IsLeapYear(1700);
            Assert.False(returnFalse);
        }

        [Fact]
        public void LeapYearDividedBy100()
        {
            var returnTrue = ly.IsLeapYear(1600);
            Assert.True(returnTrue);

            var returnFalse = ly.IsLeapYear(1700);
            Assert.False(returnFalse);
        }
    }
}