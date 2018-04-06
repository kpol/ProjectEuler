using System;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public static class Problem010
    {
        public static void Run()
        {
            // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            // Find the sum of all the primes below two million.

            ulong result = 0;

            foreach (var prime in Prime.GetPrimeNumbers(2000000 - 1))
            {
                result += prime;
            }

            Console.WriteLine(result);
        }
    }
}