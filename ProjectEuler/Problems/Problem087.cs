using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem087 : Problem<int>
    {
        // The smallest number expressible as the sum of a prime square, prime cube, and prime fourth power is 28. In fact, there are exactly four numbers below fifty that can be expressed in such a way:

        // 28 = 2^2 + 2^3 + 2^4
        // 33 = 3^2 + 2^3 + 2^4
        // 49 = 5^2 + 2^3 + 2^4
        // 47 = 2^2 + 3^3 + 2^4

        //How many numbers below fifty million can be expressed as the sum of a prime square, prime cube, and prime fourth power?

        public override int Run()
        {
            const int max = 50000000;

            var maxNumber = (int)Math.Sqrt(max) + 1;

            var primes = Prime.GetPrimeNumbersULong((ulong)maxNumber).ToList();

            var set = new HashSet<int>();

            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = 0; j < primes.Count; j++)
                {
                    var x = primes[i] * primes[i] + primes[j] * primes[j] * primes[j];

                    if (x > max)
                    {
                        break;
                    }

                    foreach (var t in primes)
                    {
                        var y = t * t * t * t;

                        if (x + y >= max)
                        {
                            break;
                        }

                        set.Add((int)(x + y));
                    }
                }
            }

            return set.Count;
        }
    }
}