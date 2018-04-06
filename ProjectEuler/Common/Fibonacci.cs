using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler.Common
{
    public static class Fibonacci
    {
        public static IEnumerable<BigInteger> GetFibonacciNumbers()
        {
            var current = new BigInteger(1);

            yield return current;

            var prev = new BigInteger(1);

            yield return current;

            while (true)
            {
                var c = current;
                current = prev + current;
                prev = c;

                yield return current;
            }
        }
    }
}