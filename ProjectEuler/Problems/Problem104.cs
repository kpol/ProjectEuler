using System.Numerics;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem104 : Problem<int>
    {
        // The Fibonacci sequence is defined by the recurrence relation:
        // Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
        // It turns out that F541, which contains 113 digits, is the first Fibonacci number for which the last nine digits are 1-9 pandigital(contain all the digits 1 to 9, but not necessarily in order). And F2749, which contains 575 digits, is the first Fibonacci number for which the first nine digits are 1-9 pandigital.
        // Given that Fk is the first Fibonacci number for which the first nine digits AND the last nine digits are 1-9 pandigital, find k.

        public override int Run()
        {
            var numbers = Fibonacci.GetFibonacciNumbers();

            const int div = 1000000000;

            int index = 1;

            foreach (var number in numbers)
            {
                if (Number.IsPandigital((int)(number % div)))
                {
                    var log = (int)BigInteger.Log10(number);
                    var n = (int)(number / BigInteger.Pow(10, log - 8));

                    if (Number.IsPandigital(n))
                    {
                        return index;
                    }
                }

                index++;
            }

            return 0;
        }
    }
}