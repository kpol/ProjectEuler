using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Common
{
    public static class Number
    {
        public static ulong RotateRight(ulong number)
        {
            var digits = (ulong)Math.Log10(number);
            var factor = (ulong)Math.Pow(10, digits);

            return number / 10 + factor * (number % 10);
        }

        public static BigInteger RotateRight(BigInteger number)
        {
            var digits = BigInteger.Log10(number);
            var factor = BigInteger.Pow(10, (int)digits);

            return number / 10 + factor * (number % 10);
        }

        public static IEnumerable<ulong> GetAllRotations(ulong number, bool includeOriginal = true)
        {
            if (includeOriginal)
            {
                yield return number;
            }

            var n = RotateRight(number);

            while (n != number)
            {
                yield return n;

                n = RotateRight(n);
            }
        }

        public static bool IsPalindromic(ulong number)
        {
            var digits = GetAllDigits(number).ToList();

            return IsPalindrome(digits);
        }

        public static IEnumerable<bool> GetBits(int number)
        {
            var b = new BitArray(new[] { number });

            var start = false;

            for (int i = b.Count - 1; i >= 0; i--)
            {
                if (start)
                {
                    yield return b[i];
                }
                else
                {
                    if (b[i])
                    {
                        start = true;
                        yield return b[i];
                    }
                }
            }
        }

        public static bool IsPalindrome<T>(IList<T> source)
        {
            return IsPalindrome(source, EqualityComparer<T>.Default);
        }

        public static bool IsPalindrome<T>(IList<T> source, IEqualityComparer<T> comparer)
        {
            for (int i = 0; i < source.Count / 2; i++)
            {
                if(!comparer.Equals(source[i], source[source.Count - 1 - i]))
                {
                    return false;
                }
            }

            return true;
        }

        public static IEnumerable<ushort> GetAllDigits(ulong number)
        {
            var n = number;

            while (n > 0)
            {
                yield return (ushort)(n % 10);

                n /= 10;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="onlyProperDivisors">A proper divisor of a positive integer is any divisor of other than itself.</param>
        /// <returns></returns>
        public static IEnumerable<ulong> GetDivisors(ulong number, bool onlyProperDivisors = true)
        {
            var max = (ulong)Math.Sqrt(number);

            yield return 1;

            for (ulong factor = 2; factor <= max; factor++)
            {
                if (number % factor == 0)
                {
                    yield return factor;

                    if (number != factor * factor)
                    {
                        yield return number / factor;
                    }
                }
            }

            if (!onlyProperDivisors)
            {
                yield return number;
            }
        }

        public static int GetMax(int number1, int number2)
        {
            return number1 >= number2 ? number1 : number2;
        }

        public static ulong TruncateLeft(ulong number)
        {
            if (number < 10)
            {
                return number;
            }

            var digits = (ulong)Math.Log10(number);
            var factor = (ulong)Math.Pow(10, digits);

            return number % factor;
        }

        public static ulong TruncateRight(ulong number)
        {
            if (number < 10)
            {
                return number;
            }

            var mod = number % 10;

            return (number - mod) / 10;
        }
    }
}