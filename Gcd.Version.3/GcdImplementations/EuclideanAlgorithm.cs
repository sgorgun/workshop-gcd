using System;

namespace Gcd.Version._3
{
    /// <inheritdoc/>
    internal class EuclideanAlgorithm : Algorithm
    {
        /// <inheritdoc/>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        protected override int Func(int first, int second) => first == 0 ? second : this.Func(second % first, first);
    }
}
