using System.Collections.Generic;
using Xunit;
using System;

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

        [Fact]
        public void Filter_can_extract_only_even_from_enumerable()
        {
            IEnumerable<int> stream = new[] { 1, 3, 5, 7, 8, 9, 10, 11, 12, 14, 16 };

            Predicate<int> even = (int i) => i % 2 == 0;
            IEnumerable<int> expected = new[] { 8, 10, 12, 14, 16 };

            Assert.Equal(expected, Iterators.Filter<int>(stream, even));
        }
    }
}
