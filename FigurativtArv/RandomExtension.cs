using System;

namespace RandomExtension
{
    /// <summary>
    /// REFERENCE: https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
    /// </summary>
    public static class RandomExtension
    {
        public static double RandomNumber(this Random random, double minValue, double maxValue) {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
        public static double RandomNumber(this Random random, int minValue, int maxValue) {
            return random.Next() * (maxValue - minValue) + minValue;
        }
    }
}