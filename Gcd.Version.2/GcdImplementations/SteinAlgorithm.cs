using System;

namespace Gcd.Version._2
{
    /// <inheritdoc/>
    internal class SteinAlgorithm : Algorithm
    {
        /// <inheritdoc/>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
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
