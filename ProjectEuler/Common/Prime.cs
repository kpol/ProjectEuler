using System;
using System.Collections.Generic;

namespace ProjectEuler.Common
{
    public static class Prime
    {
        /// <summary>
        /// A function to print all prime factors of a given number <see cref="n"/>.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="includeDuplicates"></param>
        /// <returns></returns>
        public static IEnumerable<ulong> GetPrimeFactors(ulong n, bool includeDuplicates = false)
        {
            // Print the number of 2s that divide n

            if (n % 2 == 0)
            {
                yield return 2;

                n /= 2;

                while (n % 2 == 0)
                {
                    if (includeDuplicates)
                    {
                        yield return 2;
                    }

                    n /= 2;
                }
            }

            // n must be odd at this point. So we can
            // skip one element (Note i = i +2)
            for (ulong i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (n % i == 0)
                {
                    yield return i;

                    n /= i;

                    while (n % i == 0)
                    {
                        if (includeDuplicates)
                        {
                            yield return i;
                        }

                        n /= i;
                    }
                }
            }

            // This condition is to handle the case when
            // n is a prime number greater than 2
            if (n > 2)
            {
                yield return n;
            }
        }

        public static IEnumerable<ulong> GetPrimeNumbers(ulong max)
        {
            yield return 2;
            yield return 3;

            for (ulong i = 5; i <= max; i += 2)
            {
                var found = true;

                for (ulong j = 3; j <= Math.Sqrt(i); j += 2)
                {
                    if (i % j == 0)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    yield return i;
                }
            }
        }

        public static IEnumerable<int> GetPrimeNumbersIntPreCalc(int max)
        {
            var arr = new int[max];

            for (int i = 2; i < max; i++)
            {
                for (int j = i; j < max; j += i)
                {
                    arr[j]++;
                }

                if (arr[i] == 1)
                {
                    yield return i;
                }
            }
        }

        public static bool IsPrime(ulong number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }

            if (number == 2 || number == 3)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            for (ulong i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}