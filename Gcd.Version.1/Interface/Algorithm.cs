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
            (first, second) = GetResult(first, second);
            return this.BaseAlgorithm(first, second);
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
            (first, second) = GetResult(first, second);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            var result = this.BaseAlgorithm(first, second);
            watch.Stop();
            milliseconds = watch.ElapsedMilliseconds;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers.
        /// </summary>
        /// <param name="first">First integer.</param>
        /// <param name="second">Second integer.</param>
        /// <returns>The GCD value.</returns>
        protected abstract int Func(int first, int second);

        private static (int first, int second) GetResult(int first, int second) => (first, second) switch
        {
            (0, 0) => throw new ArgumentException("All numbers are 0 at the same time."),
            (int.MinValue, _) => throw new ArgumentOutOfRangeException(nameof(first), "First number is int.MinValue."),
            (_, int.MinValue) => throw new ArgumentOutOfRangeException(nameof(second), "Second number is int.MinValue."),
            _ => (Math.Abs(first), Math.Abs(second))
        };

        private int BaseAlgorithm(int first, int second) => (first, second) switch
        {
            (0, _) => second,
            (_, 0) => first,
            _ when first == second => first,
            _ => this.Func(first, second)
        };
    }
}
