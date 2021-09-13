using Xunit;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class RegExprTests
    {

        [Fact]

        public void SplitLine_returns_split_line(){

            IEnumerable<string> input = new[] {"1024x768, 800x600, 640x480", "320x200, 320x240"};

            IEnumerable<string> expected = new[] {"1024x768", "800x600", "640x480", "320x200", "320x240"};

            Assert.Equal(expected, RegExpr.SplitLine(input));
        }

        [Fact]

        public void Resolution_returns_width_height_tuples(){

            string input = "1024x768, 800x600, 640x480, 320x200, 320x240";

            IEnumerable<(int, int)> expected = new[] {(1024, 768), (800, 600), (640, 480), (320, 200), (320,240)};

            Assert.Equal(expected, RegExpr.Resolution(input));

        }

    }
}
