using System.Collections.Generic;
using TheArtOfExtensions.Extensions;
using Xunit;

namespace TheArtOfExtensions.UnitTests
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void TryFindIndex_Should_ReturnFalse_and_MinusOne_If_NoMatch()
        {
            var aList = new List<int> {1, 2, 3, 4, 5};

            var result = aList.TryFindIndex(x => x == 6, out var noMatchIndex);

            Assert.False(result);
            Assert.Equal(-1, noMatchIndex);
        }

        [Fact]
        public void TryFindIndex_Should_ReturnTrue_and_TheIndex_If_Match()
        {
            var aList = new List<int> { 1, 2, 3, 4, 5 };

            var result = aList.TryFindIndex(x => x == 4, out var matchIndex);

            Assert.True(result);
            Assert.Equal(3, matchIndex);
        }
    }
}
