using System;
using Gcd.GcdImplementations;
using Gcd.Interface;

namespace Gcd.StaticClasses
{
    public static class GcdAlgorithms
    {
        public static int GetGcdByEuclidean(int first, int second) => Gcd(new EuclideanAlgorithm(), first, second);

        public static int GetGcdByEuclidean(int first, int second, int third) =>
            Gcd(new EuclideanAlgorithm(), first, second, third);

        public static int GetGcdByEuclidean(int first, int second, params int[] numbers) =>
            Gcd(new EuclideanAlgorithm(), first, second, numbers);

        public static int GetGcdByEuclidean(out long elapsedTicks, int first, int second) =>
            Gcd(new EuclideanAlgorithm(), out elapsedTicks, first, second);

        public static int GetGcdByEuclidean(out long elapsedTicks, int first, int second, int third) =>
            Gcd(new EuclideanAlgorithm(), out elapsedTicks, first, second, third);

        public static int GetGcdByEuclidean(out long elapsedTicks, int first, int second, params int[] numbers) =>
            Gcd(new EuclideanAlgorithm(), out elapsedTicks, first, second, numbers);

        private static int Gcd(Algorithm algorithm, int first, int second) => algorithm.Calculate(first, second);

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second) =>
            algorithm.Calculate(first, second, out milliseconds);

        private static int Gcd(Algorithm algorithm, int first, int second, int third) =>
            throw new NotImplementedException();

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second, int third) =>
            throw new NotImplementedException();

        private static int Gcd(Algorithm algorithm, int first, int second, params int[] numbers) =>
            throw new NotImplementedException();

        private static int Gcd(Algorithm algorithm, out long milliseconds, int first, int second, params int[] numbers) =>
            throw new NotImplementedException();
    }
}
