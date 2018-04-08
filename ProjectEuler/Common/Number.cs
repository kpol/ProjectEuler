using System;
using System.Collections.Generic;

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
    }
}