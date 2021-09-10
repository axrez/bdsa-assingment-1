using System.Collections.Generic;
using Xunit;

namespace Assignment1.Tests
{
    public class IteratorsTests
    {
        [Fact]
        public void Flatten_can_extract_stream_from_enumerable_enumerable()
        {
            IEnumerable<int> stream = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<IEnumerable<int>> streamOfStreams = new[] { stream, stream, stream };

            IEnumerable<int> expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.Equal(expected, Iterators.Flatten<int>(streamOfStreams));
        }
    }
}
