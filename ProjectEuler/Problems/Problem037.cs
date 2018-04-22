using System;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem037 : Problem<ulong>
    {
        // The number 3797 has an interesting property.Being prime itself, it is possible to continuously remove digits from left to right, and remain prime at each stage: 3797, 797, 97, and 7. Similarly we can work from right to left: 3797, 379, 37, and 3.
        // Find the sum of the only eleven primes that are both truncatable from left to right and right to left.
        // NOTE: 2, 3, 5, and 7 are not considered to be truncatable primes.
        
        public override ulong Run()
        {
            var primes = Prime.GetPrimeNumbersULong(ulong.MaxValue).SkipWhile(n => n < 10);

            var count = 0;

            ulong sum = 0;

            foreach (var prime in primes)
            {
                if (Truncatable(prime, Number.TruncateLeft) && Truncatable(prime, Number.TruncateRight))
                {
                    count++;
                    sum += prime;

                    // we know that number of theese numbers is 11
                    if (count == 11)
                    {
                        return sum;
                    }
                }
            }

            return 0;
        }

        private static bool Truncatable(ulong number, Func<ulong, ulong> truncate)
        {
            ulong n = number;

            while ((n = truncate(n)) >= 10)
            {
                if (!Prime.IsPrime(n))
                {
                    return false;
                }
            }

            return Prime.IsPrime(n);
        }
    }
}