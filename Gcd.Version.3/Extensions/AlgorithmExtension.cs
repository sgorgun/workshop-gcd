using System;
using System.Diagnostics;
using Gcd.Version._3;
#pragma warning disable SA1401

namespace Gcd.Version._3.Extensions
{
    /// <summary>
    /// Class with extension methods for algorithms.
    /// </summary>
    internal abstract class AlgorithmExtension : IAlgorithm
    {
        /// <summary>
        /// <see cref="IAlgorithm"/> Object.
        /// </summary>
        protected readonly IAlgorithm algorithm;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlgorithmExtension"/> class.
        /// </summary>
        /// <param name="algorithm">Algorithm.</param>
        /// <exception cref="ArgumentNullException">Cant be null.</exception>
        protected AlgorithmExtension(IAlgorithm algorithm)
        {
            this.algorithm = algorithm ?? throw new ArgumentNullException(nameof(algorithm), "cant be null.");
        }

        /// <summary>
        /// Calculate GTD.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Secong value.</param>
        /// <returns>Return GTD.</returns>
        public abstract int Calculate(int first, int second);

        /// <summary>
        /// Calculate GTD.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Secong value.</param>
        /// <param name="third">Third value.</param>
        /// <returns>Return GTD.</returns>
        public abstract int Calculate(int first, int second, int third);

        /// <summary>
        /// Calculate GTD.
        /// </summary>
        /// <param name="first">First value.</param>
        /// <param name="second">Secong value.</param>
        /// <param name="numbers">Array of numbers.</param>
        /// <returns>Return GTD.</returns>
        public abstract int Calculate(int first, int second, params int[] numbers);
    }
}
