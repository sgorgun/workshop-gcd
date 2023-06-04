using System;

namespace Gcd.Version._1
{
    /// <summary>
    /// Calculates the GCD by the Stein algorithm.
    /// </summary>
    internal class SteinAlgorithm : Algorithm
    {
        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        protected override int Func(int first, int second) =>
            (first, second) switch
            {
                _ when first == second => first,
                _ when first == 0 => second,
                _ when second == 0 => first,
                _ when (first & 1) == 0 => (second & 1) switch
                {
                    _ when (second & 1) == 0 => 2 * this.Calculate(first >> 1, second >> 1),
                    _ => this.Calculate(first >> 1, second)
                },
                _ when (second & 1) == 0 => this.Calculate(first, second >> 1),
                _ when first > second => this.Calculate((first - second) >> 1, second),
                _ => this.Calculate((second - first) >> 1, first)
            };
    }
}
