using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem187 : Problem<int>
    {
        // A composite is a number containing at least two prime factors.For example, 15 = 3 × 5; 9 = 3 × 3; 12 = 2 × 2 × 3.
        // There are ten composites below thirty containing precisely two, not necessarily distinct, prime factors: 4, 6, 9, 10, 14, 15, 21, 22, 25, 26.
        // How many composite integers, n < 108, have precisely two, not necessarily distinct, prime factors?

        public override int Run()
        {
            const int max = 100000000;

            var primes = Prime.GetPrimeNumbersIntPreCalc(max / 2).ToList();

            int count = 0;

            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = i; j < primes.Count; j++)
                {
                    var x = (long)primes[i] * primes[j];

                    if (x < max)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return count;
        }
    }
}