using TheArtOfExtensions.Extensions;
using Xunit;

namespace TheArtOfExtensions.UnitTests
{
    public class FloatingPointsNumberExtensionsTests
    {
        [Fact]
        public void AsTruncatedInteger_Should_Return_Integer()
        {
            const float someFloat = 1.9876f;
            const int expected = 1;

            var result = someFloat.AsTruncatedInteger();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void AsRoundedInteger_Should_Return_LowInteger()
        {
            const float someFloat = 1.2345f;
            const int expected = 1;

            var result = someFloat.AsRoundedInteger();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void AsRoundedInteger_Should_Return_HighInteger()
        {
            const float someFloat = 1.98765f;
            const int expected = 2;

            var result = someFloat.AsRoundedInteger();

            Assert.Equal(expected, result);
        }
    }
}