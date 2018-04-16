using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem179 : Problem<int>
    {
        // Find the number of integers 1 < n < 10^7, for which n and n + 1 have the same number of positive divisors.For example, 14 has the positive divisors 1, 2, 7, 14 while 15 has 1, 3, 5, 15.

        public override int Run()
        {
            var n1 = Number.GetDivisors(2, false).Count();

            var count = 0;

            for (int i = 3; i < 10000000; i++)
            {
                var n2 = Number.GetDivisors(i, false).Count();

                if (n1 == n2)
                {
                    count++;
                }

                n1 = n2;
            }

            return count;
        }
    }
}