using System;

namespace TheArtOfExtensions.Extensions
{
    public static class FloatingPointNumbersExtensions
    {
        public static int AsTruncated(this float value)
        {
            return (int) Math.Truncate(value);
        }

        public static int AsRounded(this float value)
        {
            return (int) Math.Round(value);
        }
    }
}
