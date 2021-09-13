using Xunit;
using System.Collections.Generic;
using System;

namespace Assignment1.Tests
{
    public class RegExprTests
    {


        [Fact]
        public static void Can_SplitLine_Split_A_Line(){

            IEnumerable<string> input = new[] {"1024x768, 800x600, 640x480"};

            IEnumerable<string> expected = new[] {"1024x768", "800x600", "640x480"};



            Assert.Equal(expected, RegExpr.SplitLine(input));


        }
    }
}
