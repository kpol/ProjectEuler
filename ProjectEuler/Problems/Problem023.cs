using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem023 : Problem
    {
        // A perfect number is a number for which the sum of its proper divisors is exactly equal to the number.For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
        // A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
        // As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.
        // Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.

        public override void Run()
        {
            var abundantNumbers = new SortedSet<int>();

            const int max = 28123;

            for (int i = 1; i <= max; i++)
            {
                if (IsAbundant(i))
                {
                    abundantNumbers.Add(i);
                }
            }

            int sum = 0;

            for (int i = 1; i <= max; i++)
            {
                if (!CanBeSumOfTwoAbundant(i, abundantNumbers))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="abundantNumbers">Sorted array.</param>
        /// <returns></returns>
        private static bool CanBeSumOfTwoAbundant(int number, ICollection<int> abundantNumbers)
        {
            foreach (var abundantNumber in abundantNumbers)
            {
                if (abundantNumber >= number)
                {
                    break;
                }

                var diff = number - abundantNumber;

                if (abundantNumbers.Contains(diff))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsAbundant(int number)
        {
            var sumAllDivisors = Number.GetDivisors(number).Sum();

            return sumAllDivisors > number;
        }
    }
}