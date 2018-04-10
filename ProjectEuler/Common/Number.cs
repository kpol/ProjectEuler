using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Common
{
    public static class Number
    {
        public static ulong RotateInteger(ulong number)
        {
            var digits = (ulong)Math.Log10(number);
            var factor = (ulong)Math.Pow(10, digits);

            return number / 10 + factor * (number % 10);
        }

        public static IEnumerable<ulong> GetAllRotations(ulong number, bool includeOriginal = true)
        {
            if (includeOriginal)
            {
                yield return number;
            }

            var n = RotateInteger(number);

            while (n != number)
            {
                yield return n;

                n = RotateInteger(n);
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
    }
}