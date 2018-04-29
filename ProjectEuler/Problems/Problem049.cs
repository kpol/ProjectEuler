using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem049 : Problem<string>
    {
        // The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: (i) each of the three terms are prime, and, (ii) each of the 4-digit numbers are permutations of one another.
        // There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.
        // What 12-digit number do you form by concatenating the three terms in this sequence?

        public override string Run()
        {
            const int max = 9999;

            var primes = Prime.GetPrimeNumbers(max).SkipWhile(n => n < 1000).Select(n => (int)n).ToList();

            for (int i = 0; i < primes.Count - 2; i++)
            {
                if (primes[i] == 1487)
                {
                    continue;
                }

                for (int j = i + 1; j < primes.Count - 1; j++)
                {
                    if (!Number.IsPermutation(primes[i], primes[j]))
                    {
                        continue;
                    }

                    var diff = primes[j] - primes[i];

                    var n3 = primes[j] + diff;

                    if (primes.BinarySearch(n3) >= 0 && Number.IsPermutation(primes[i], n3))
                    {
                        return $"{primes[i]}{primes[j]}{n3}";
                    }
                }
            }

            return string.Empty;
        }
    }
}