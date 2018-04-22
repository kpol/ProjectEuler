using System;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem046 : Problem<ulong>
    {
        // It was proposed by Christian Goldbach that every odd composite number can be written as the sum of a prime and twice a square.

        // 9 = 7 + 2×1^2
        // 15 = 7 + 2×2^2
        // 21 = 3 + 2×3^2
        // 25 = 7 + 2×3^2
        // 27 = 19 + 2×2^2
        // 33 = 31 + 2×1^2

        // It turns out that the conjecture was false.
        // What is the smallest odd composite that cannot be written as the sum of a prime and twice a square?

        public override ulong Run()
        {
            const ulong max = 1000000;

            var primes = Prime.GetPrimeNumbersULong(max).ToArray();

            for (ulong i = 3; i < max; i += 2)
            {
                if (!Prime.IsPrime(i))
                {
                    var pr = primes.TakeWhile(p => p < i).ToList();

                    var canBeWritten = false;

                    foreach (var p in pr)
                    {
                        var x = i - p;

                        if (x % 2 == 0)
                        {
                            var z = x / 2;

                            var sqrt = (ulong)Math.Sqrt(z);

                            if (sqrt * sqrt == z)
                            {
                                canBeWritten = true;

                                break;
                            }
                        }
                    }

                    if (!canBeWritten)
                    {
                        return i;
                    }
                }
            }

            return 0;
        }
    }
}