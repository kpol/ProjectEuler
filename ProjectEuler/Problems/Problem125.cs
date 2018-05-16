using System;
using System.Collections.Generic;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem125 : Problem<long>
    {
        // The palindromic number 595 is interesting because it can be written as the sum of consecutive squares: 6^2 + 7^2 + 8^2 + 9^2 + 10^2 + 11^2 + 122.
        // There are exactly eleven palindromes below one-thousand that can be written as consecutive square sums, and the sum of these palindromes is 4164. Note that 1 = 0^2 + 1^2 has not been included as this problem is concerned with the squares of positive integers.
        // Find the sum of all the numbers less than 108 that are both palindromic and can be written as the sum of consecutive squares.

        public override long Run()
        {
            const int max = (int)1e8;

            var set = new HashSet<int>();

            for (int i = 1; i < max; i++)
            {
                if (Number.IsPalindrome(i))
                {
                    set.Add(i);
                }
            }

            var result = new HashSet<int>();

            for (int i = 1; i <= Math.Sqrt(max); i++)
            {
                int k = 0;
                int sum = 0;

                while (sum < max)
                {
                    sum += (i + k) * (i + k);

                    if (k > 0 && sum < max && set.Contains(sum))
                    {
                        result.Add(sum);
                    }

                    k++;
                }
            }

            return result.SumLong();
        }
    }
}