using System;
using System.Numerics;

namespace ProjectEuler.Problems
{
    // The first known prime found to exceed one million digits was discovered in 1999, and is a Mersenne prime of the form 26972593−1; it contains exactly 2,098,960 digits.Subsequently other Mersenne primes, of the form 2p−1, have been found which contain more digits.
    // However, in 2004 there was found a massive non-Mersenne prime which contains 2,357,207 digits: 28433×2^7830457+1.
    // Find the last ten digits of this prime number.

    public class Problem097 : Problem<long>
    {
        public override long Run()
        {
            var b = new byte[7830457 / 8 + 1];
            b[7830457 / 8] = (byte)Math.Pow(2, 7830457 % 8);

            return (long) ((28433 * new BigInteger(b) + 1) % 10000000000);
        }
    }
}