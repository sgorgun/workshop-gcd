using System;
using Gcd.Version._3;

namespace Gcd.Version._3.Extensions
{
    /// <summary>
    /// Interface extension for calculating the GCD of integers.
    /// </summary>
    internal class AlgorithmParameters : AlgorithmExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlgorithmParameters"/> class.
        /// </summary>
        /// <param name="algorithm">Algorithm.</param>
        public AlgorithmParameters(IAlgorithm algorithm)
            : base(algorithm)
        {
        }

        /// <summary>
        /// Get GCD of two numbers.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <returns>GCD.</returns>
        public override int Calculate(int first, int second) => this.algorithm.Calculate(first, second);

        /// <summary>
        /// Get GCD of three numbers.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <param name="third">Third value.</param>
        /// <returns>GCD.</returns>
        public override int Calculate(int first, int second, int third)
        {
            if (first == 0)
            {
                return this.Calculate(second, third);
            }

            var gcd = this.algorithm.Calculate(first, second);
            return this.algorithm.Calculate(gcd, third);
        }

        /// <summary>
        /// Get GCD of numbers.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <param name="numbers">Third value.</param>
        /// <returns>GCD.</returns>
        public override int Calculate(int first, int second, params int[] numbers)
        {
            var gcd = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    gcd = this.algorithm.Calculate(gcd, numbers[i]);
                }
            }

            return this.Calculate(first, second, gcd);
        }
    }
}
