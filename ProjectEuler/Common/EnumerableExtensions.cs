using System;
using System.Collections.Generic;

namespace ProjectEuler.Common
{
    public static class EnumerableExtensions
    {
        public static ulong Sum(this IEnumerable<ulong> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            ulong sum = 0;

            foreach (var item in source)
            {
                sum += item;
            }

            return sum;
        }
    }
}