using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem043 : Problem<long>
    {
        // The number, 1406357289, is a 0 to 9 pandigital number because it is made up of each of the digits 0 to 9 in some order, but it also has a rather interesting sub-string divisibility property.
           
        // Let d1 be the 1st digit, d2 be the 2nd digit, and so on.In this way, we note the following:
           
        // d2d3d4= 406 is divisible by 2
        // d3d4d5= 063 is divisible by 3
        // d4d5d6= 635 is divisible by 5
        // d5d6d7= 357 is divisible by 7
        // d6d7d8= 572 is divisible by 11
        // d7d8d9= 728 is divisible by 13
        // d8d9d10= 289 is divisible by 17
        // Find the sum of all 0 to 9 pandigital numbers with this property.

        public override long Run()
        {
            var numbers = Enumerable.Range(0, 10).GetAllPermutations();

            long sum = 0;

            foreach (var n in numbers)
            {
                if (CheckNumber(n))
                {
                    sum += long.Parse(string.Concat(n));
                }
            }

            return sum;
        }

        private static bool CheckNumber(IList<int> n)
        {
            return GetNumber(n[1], n[2], n[3]) % 2 == 0
                   && GetNumber(n[2], n[3], n[4]) % 3 == 0
                   && GetNumber(n[3], n[4], n[5]) % 5 == 0
                   && GetNumber(n[4], n[5], n[6]) % 7 == 0
                   && GetNumber(n[5], n[6], n[7]) % 11 == 0
                   && GetNumber(n[6], n[7], n[8]) % 13 == 0
                   && GetNumber(n[7], n[8], n[9]) % 17 == 0;
        }

        private static int GetNumber(int a, int b, int c)
        {
            return a * 100 + b * 10 + c;
        }
    }
}