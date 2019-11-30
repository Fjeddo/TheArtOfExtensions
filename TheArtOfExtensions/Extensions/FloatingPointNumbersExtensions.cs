using System;

namespace TheArtOfExtensions.Extensions
{
    public static class FloatingPointNumbersExtensions
    {
        public static int AsTruncatedInteger(this float value)
        {
            return (int) Math.Truncate(value);
        }

        public static int AsRoundedInteger(this float value)
        {
            return (int) Math.Round(value);
        }
    }
}
