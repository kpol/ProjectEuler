using System;

namespace ProjectEuler.Problems
{
    public static class Problem006
    {
        public static void Run()
        {
            // The sum of the squares of the first ten natural numbers is,
            // 1^2 + 2^2 + ... + 10^2 = 385
            // The square of the sum of the first ten natural numbers is,
            // (1 + 2 + ... + 10)^2 = 55^2 = 3025
            // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

            ulong sumOfSquares = 0;
            ulong sum = 0;

            for (ulong i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                sum += i;
            }

            var result = sum * sum - sumOfSquares;

            Console.WriteLine(result);
        }
    }
}