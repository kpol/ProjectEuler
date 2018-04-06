using System;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public static class Problem003
    {
        public static void Run()
        {
            // The prime factors of 13195 are 5, 7, 13 and 29.
            // What is the largest prime factor of the number 600851475143?

            var result = Prime.PrimeFactors(600851475143).OrderByDescending(n => n).First();

            Console.WriteLine(result);
        }
    }
}