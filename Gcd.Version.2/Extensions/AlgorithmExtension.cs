using System;
using System.Diagnostics;

namespace Gcd.Version._2.Extensions
{
    /// <summary>
    /// Extension methods for algorithms.
    /// </summary>
    internal static class AlgorithmExtension
    {
        /// <summary>
        /// Calculates GCD of two integers.
        /// </summary>
        /// <param name="algorithm">Object.</param>
        /// <param name="milliseconds">Time metod.</param>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <returns>The GHD value.</returns>
        /// <exception cref="ArgumentNullException">Thriw when algoritm lenght 0.</exception>
        public static int Calculate(this IAlgorithm algorithm, out long milliseconds, int first, int second)
        {
            if (algorithm == null)
            {
                throw new ArgumentNullException(nameof(algorithm), "is null");
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var result = algorithm.Calculate(first, second);

            stopwatch.Stop();
            milliseconds = stopwatch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Calculates GCD of two integers.
        /// </summary>
        /// <param name="algorithm">Object.</param>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <param name="third"><Third.</param>
        /// <returns>The GHD value.</returns>
        /// <exception cref="ArgumentNullException">Thriw when algoritm lenght 0.</exception>
        public static int Calculate(this IAlgorithm algorithm, int first, int second, int third)
        {
            if (algorithm == null)
            {
                throw new ArgumentNullException(nameof(algorithm), "is null");
            }

            if (first == 0)
            {
                return algorithm.Calculate(second, third);
            }

            var gcd = algorithm.Calculate(first, second);
            return algorithm.Calculate(gcd, third);
        }

        /// <summary>
        /// Calculates GCD of two integers.
        /// </summary>
        /// <param name="algorithm">Object.</param>
        /// <param name="milliseconds">Time metod.</param>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <param name="third">Third value.</param>
        /// <returns>The GHD value.</returns>
        /// <exception cref="ArgumentNullException">Thriw when algoritm lenght 0.</exception>
        public static int Calculate(this IAlgorithm algorithm, out long milliseconds, int first, int second, int third)
        {
            if (algorithm == null)
            {
                throw new ArgumentNullException(nameof(algorithm), "is null");
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var result = algorithm.Calculate(first, second, third);

            stopwatch.Stop();
            milliseconds = stopwatch.ElapsedMilliseconds;

            return result;
        }

        /// <summary>
        /// Calculates GCD of two integers.
        /// </summary>
        /// <param name="algorithm">Object.</param>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <param name="numbers">Numbers values.</param>
        /// <returns>The GHD value.</returns>
        /// <exception cref="ArgumentNullException">Thriw when algoritm lenght 0.</exception>
        public static int Calculate(this IAlgorithm algorithm, int first, int second, params int[] numbers)
        {
            if (algorithm == null)
            {
                throw new ArgumentNullException(nameof(algorithm), "is null");
            }

            var gcd = 0;

            foreach (var number in numbers)
            {
                if (number != 0)
                {
                    gcd = algorithm.Calculate(gcd, number);
                }
            }

            return Calculate(algorithm, first, second, gcd);
        }

        /// <summary>
        /// Calculates GCD of two integers.
        /// </summary>
        /// <param name="algorithm">Object.</param>
        /// <param name="milliseconds">Time metod.</param>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <param name="numbers">Numbers values.</param>
        /// <returns>The GHD value.</returns>
        /// <exception cref="ArgumentNullException">Thriw when algoritm lenght 0.</exception>
        public static int Calculate(this IAlgorithm algorithm, out long milliseconds, int first, int second, params int[] numbers)
        {
            if (algorithm == null)
            {
                throw new ArgumentNullException(nameof(algorithm), "is null");
            }

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var result = algorithm.Calculate(first, second, numbers);

            stopwatch.Stop();
            milliseconds = stopwatch.ElapsedMilliseconds;

            return result;
        }
    }
}
