using System;

namespace Gcd
{
    public static class GcdAlgorithms
    {
        #region Euclidean Algorithms (API)

        public static int FindGcdByEuclidean(int first, int second)
            => Gcd(first, second, new EuclideanAlgorithm());

        public static int FindGcdByEuclidean(out long milliseconds, int first, int second)
            => Gcd(first, second, out milliseconds, new EuclideanAlgorithm());

        public static int FindGcdByEuclidean(int first, int second, int third)
            => Gcd(first, second, third, new EuclideanAlgorithm());

        public static int FindGcdByEuclidean(out long milliseconds, int first, int second, int third)
            => Gcd(first, second, third, out milliseconds, new EuclideanAlgorithm());

        public static int FindGcdByEuclidean(params int[] numbers)
            => Gcd(new EuclideanAlgorithm(), numbers);

        public static int FindGcdByEuclidean(out long milliseconds, params int[] numbers)
            => Gcd(new EuclideanAlgorithm(), out milliseconds, numbers);

        #endregion

        #region Helper methods

        private static int Gcd(int first, int second, Algorithm algorithm)
            => algorithm.Calculate(first, second);

        private static int Gcd(int first, int second, out long milliseconds, Algorithm algorithm)
            => algorithm.Calculate(first, second, out milliseconds);

        private static int Gcd(int first, int second, int third, Algorithm algorithm)
            => throw new NotImplementedException();

        private static int Gcd(int first, int second, int third, out long milliseconds, Algorithm algorithm)
            => throw new NotImplementedException();

        private static int Gcd(Algorithm algorithm, params int[] numbers)
            => throw new NotImplementedException();

        private static int Gcd(Algorithm algorithm, out long milliseconds, params int[] numbers)
            => throw new NotImplementedException();

        #endregion
    }
}