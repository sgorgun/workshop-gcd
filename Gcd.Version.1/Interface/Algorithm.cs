using System;

namespace Gcd.Version._1
{
    /// <summary>
    /// Provide methods to calculates GCD.
    /// </summary>
    internal abstract class Algorithm
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue].
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public int Calculate(int first, int second)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue].
        /// </summary>
        /// <param name="milliseconds">Method execution time in milliseconds.</param
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public int Calculate(int first, int second, out long milliseconds)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the GCD of integers.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        protected abstract int Func(int first, int second);
    }
}