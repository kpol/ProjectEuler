using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem050 : Problem<ulong>
    {
        // Consider the number 142857. We can right-rotate this number by moving the last digit (7) to the front of it, giving us 714285.
        // It can be verified that 714285=5×142857.
        // This demonstrates an unusual property of 142857: it is a divisor of its right-rotation.
        // Find the last 5 digits of the sum of all integers n, 10 < n < 10^100, that have this property.

        public override ulong Run()
        {
            var primes = Prime.GetPrimeNumbersULong((int)1e6 - 1).ToList();

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