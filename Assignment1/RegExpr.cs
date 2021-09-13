using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Assignment1
{
    public static class RegExpr
    {
        public static IEnumerable<string> SplitLine(IEnumerable<string> lines)
        {
            foreach (string line in lines)
            {
                var matches = Regex.Matches(line, @"[a-zA-Z0-9]+");
                foreach (var match in matches)
                {
                    yield return match.ToString();
                }
            }
        }

        public static IEnumerable<(int width, int height)> Resolution(string resolutions)
        {
            var matches = Regex.Matches(resolutions, @"(?<width>\d+)x(?<height>\d+)");

            foreach (Match match in matches){

                yield return (Int32.Parse(match.Groups["width"].Value), Int32.Parse(match.Groups["height"].Value));

            }
        }

        public static IEnumerable<string> InnerText(string html, string tag)
        {
            throw new NotImplementedException();
        }
    }
}
