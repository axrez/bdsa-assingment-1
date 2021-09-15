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

        [Fact]

        public void InnerText_returns_stream_of_text_between_chosen_tag(){

            string input = @"<div>
                            <p>This text <i>is</i> test <u>text.</u> There <em>are</em> none like it.</p></div>    <div><div><p> 
                            This one, <em>however</em>, is way <u>cooler</u>.</p></div></div>
                            <div><p>             Regardless, <u>the last one</u> truly takes the cake.                  </p></div>";

            IEnumerable<string> expected = new[] {"This text is test text. There are none like it.", "This one, however, is way cooler.",
                                                    "Regardless, the last one truly takes the cake."};
            

            Assert.Equal(expected, RegExpr.InnerText(input, "p"));
        }

    }
}
