using System;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problem048 : Problem
    {
        public override void Run()
        {
            // The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.
            // Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.

            var sum = new BigInteger();

            for (int i = 1; i <= 1000; i++)
            {
                var n = BigInteger.Pow(new BigInteger(i), i);
                sum += n;
            }

            var str = sum.ToString();
            var result = str.Substring(str.Length - 10);

            Console.WriteLine(result);
            Console.WriteLine(sum - sum / 10000000000 * 10000000000);
        }
    }
}