using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem050 : Problem<ulong>
    {
        // The prime 41, can be written as the sum of six consecutive primes:
        // 41 = 2 + 3 + 5 + 7 + 11 + 13
        // This is the longest sum of consecutive primes that adds to a prime below one-hundred.
        // The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
        // Which prime, below one-million, can be written as the sum of the most consecutive primes?

        public override ulong Run()
        {
            const int max = (int)1e6;

            var primes = Prime.GetPrimeNumbers(max - 1).ToList();
            var set = new HashSet<ulong>(primes);

            int maxSequenceCount = 0;
            ulong pr = 0;

            for (int i = 0; i < primes.Count - 2; i++)
            {
                ulong sum = 0;
                int count = 0;

                for (int j = i + 1; j < primes.Count - 1; j++)
                {
                    sum += primes[j];
                    count++;

                    if (sum > max)
                    {
                        break;
                    }

                    if (set.Contains(sum) && count > maxSequenceCount)
                    {
                        pr = sum;
                        maxSequenceCount = count;
                    }
                }
            }


            return pr;
        }
    }
}