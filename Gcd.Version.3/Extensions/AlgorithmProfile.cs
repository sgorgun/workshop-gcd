using System;
using System.Diagnostics;

namespace Gcd.Version._3.Extensions
{
    /// <summary>
    /// Interfaces extension methods for algorithms.
    /// </summary>
    internal class AlgorithmProfile : AlgorithmExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlgorithmProfile"/> class.
        /// The new instance of the <see cref="AlgorithmProfile"/> class.
        /// </summary>
        /// <param name="algorithm">Algorithm.</param>
        public AlgorithmProfile(Algorithm algorithm)
            : base(algorithm)
        {
        }

        /// <summary>
        /// Gets fotr time.
        /// </summary>
        public long Milliseconds { get; private set; }

        /// <summary>
        /// Get GCD of two integers.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <returns>GCD.</returns>
        public override int Calculate(int first, int second)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var gcd = this.algorithm.Calculate(first, second);

            stopwatch.Stop();

            this.Milliseconds = stopwatch.ElapsedMilliseconds;
            return gcd;
        }

        /// <summary>
        /// Get GCD of three integers.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <param name="third">Third value.</param>
        /// <returns>GCD.</returns>
        public override int Calculate(int first, int second, int third)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int gcd;
            if (first == 0)
            {
                gcd = this.algorithm.Calculate(second, third);
            }
            else
            {
                gcd = this.algorithm.Calculate(first, second);
                gcd = this.algorithm.Calculate(gcd, third);
            }

            stopwatch.Stop();
            this.Milliseconds = stopwatch.ElapsedMilliseconds;
            return gcd;
        }

        /// <summary>
        /// Get GCD of four integers.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Second value.</param>
        /// <param name="numbers">Third value.</param>
        /// <returns>GCD.</returns>
        public override int Calculate(int first, int second, params int[] numbers)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int gcd = numbers.Where(x => x != 0).Aggregate(0, (current, number) => this.algorithm.Calculate(current, number));

            if (first == 0)
            {
                gcd = this.algorithm.Calculate(gcd, second);
            }
            else
            {
                gcd = this.algorithm.Calculate(gcd, first);
                gcd = this.algorithm.Calculate(gcd, second);
            }

            stopwatch.Stop();
            this.Milliseconds = stopwatch.ElapsedMilliseconds;
            return gcd;
        }
    }
}
