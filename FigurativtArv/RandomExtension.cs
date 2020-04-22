using System;

namespace RandomExtension
{
    /// <summary>
    /// REFERENCE: https://stackoverflow.com/questions/1064901/random-number-between-2-double-numbers
    /// </summary>
    public static class RandomExtension
    {
        /// <summary>
        /// Returns a random double
        /// </summary>
        /// <param name="random">An instance of the class Random</param>
        /// <param name="minValue">The minimum random double</param>
        /// <param name="maxValue">The maximum random double</param>
        /// <returns>A random double</returns>
        public static double RandomDouble(this Random random, double minValue, double maxValue) {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }
}