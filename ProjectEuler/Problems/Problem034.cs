using System;
using System.Numerics;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem034 : Problem
    {
        // 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
        // Find the sum of all numbers which are equal to the sum of the factorial of their digits.
        // Note: as 1! = 1 and 2! = 2 are not sums they are not included.

        public override void Run()
        {
            var max = Factorial.GetFactorial(9) * 8;

            ulong sum = 0;

            for (ulong i = 3; i < max; i++)
            {
                var digits = Number.GetAllDigits(i);

                BigInteger s = 0;

                foreach (var d in digits)
                {
                    var f = Factorial.GetFactorial(d);
                    s += f;

                    if (s > i)
                    {
                        break;
                    }
                }

                if (s == i)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}