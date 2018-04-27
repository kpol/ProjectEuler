using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem060 : Problem<int>
    {
        // The primes 3, 7, 109, and 673, are quite remarkable.By taking any two primes and concatenating them in any order the result will always be prime. For example, taking 7 and 109, both 7109 and 1097 are prime. The sum of these four primes, 792, represents the lowest sum for a set of four primes with this property.
        // Find the lowest sum for a set of five primes for which any two primes concatenate to produce another prime.

        public override int Run()
        {
            var primes = Prime.GetPrimeNumbers(10000).Select(n => (int)n).ToArray();

            for (int i = 0; i < primes.Length - 4; i++)
            {
                for (int j = i + 1; j < primes.Length - 3; j++)
                {
                    if (!IsPrime(i, j, primes))
                    {
                        continue;
                    }

                    for (int k = j + 1; k < primes.Length - 2; k++)
                    {
                        if (!IsPrime(i, k, primes)
                            || !IsPrime(j, k, primes))
                        {
                            continue;
                        }

                        for (int l = k + 1; l < primes.Length - 1; l++)
                        {
                            if (!IsPrime(i, l, primes)
                                || !IsPrime(j, l, primes)
                                || !IsPrime(k, l, primes))
                            {
                                continue;
                            }

                            for (int m = l + 1; m < primes.Length; m++)
                            {
                                if (!IsPrime(i, m, primes)
                                    || !IsPrime(j, m, primes)
                                    || !IsPrime(k, m, primes)
                                    | !IsPrime(l, m, primes))
                                {
                                    continue;
                                }

                                return primes[i] + primes[j] + primes[k] + primes[l] + primes[m];
                            }
                        }
                    }
                }
            }

            return 0;
        }

        private static bool IsPrime(int index1, int index2, int[] primes)
        {
            if (!Prime.IsPrime((ulong)Number.ConcatenateNumbers(primes[index1], primes[index2])))
            {
                return false;
            }

            return Prime.IsPrime((ulong)Number.ConcatenateNumbers(primes[index2], primes[index1]));
        }
    }
}