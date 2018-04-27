using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.Text;
using ProjectEuler.Common;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    public class Program
    {
        //Problem 60

        public static void Main(string[] args)
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

                                Console.WriteLine(i + j + k + l + m);
                            }
                        }
                    }
                }
            }
        }

        private static bool IsPrime(int index1, int index2, int[]primes)
        {
            if (!Prime.IsPrime((ulong)Number.ConcatenateNumbers(primes[index1], primes[index2])))
            {
                return false;
            }

            return Prime.IsPrime((ulong)Number.ConcatenateNumbers(primes[index2], primes[index1]));
        }
    }
}