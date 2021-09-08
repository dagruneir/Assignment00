using System;
using System.IO;
using Xunit;

namespace Assignment00.test
{
    public class UnitTest1
    {
        [Fact]
        public void Main_prints_hello_world()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);

            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello World!", output);
        }
    }
}
