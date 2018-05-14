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
            var primes = Prime.GetPrimeNumbers((int)1e6 - 1).ToList();

            int maxSequenceCount = 0;
            ulong pr = 0;
            for (int i = primes.Count - 1; i > 0; i--)
            {
                var prime = primes[i];

                int start = 0;

                while (start < i - 1)
                {
                    ulong sum = 0;
                    var count = 0;

                    for (int j = start; j < i - 1; j++)
                    {
                        count++;
                        sum += primes[j];

                        if (sum == prime)
                        {
                            if (maxSequenceCount < count)
                            {
                                maxSequenceCount = count;
                                pr = prime;
                            }

                            break;
                        }

                        if (sum > prime)
                        {
                            break;
                        }
                    }

                    start++;
                }
            }

            return pr;
        }
    }
}