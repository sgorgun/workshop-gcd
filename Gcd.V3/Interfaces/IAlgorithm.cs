namespace Gcd.V3.Interfaces
{
    /// <summary>
    /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue].
    /// </summary>
    internal interface IAlgorithm
    {
        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue].
        /// </summary>
        /// <param name="first">first value.</param>
        /// <param name="second">second value.</param>
        /// <returns>The GCD value.</returns>
        int Calculate(int first, int second);
    }
}
