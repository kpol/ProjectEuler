using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem145 : Problem<int>
    {
        // Some positive integers n have the property that the sum[n + reverse(n)] consists entirely of odd(decimal) digits.For instance, 36 + 63 = 99 and 409 + 904 = 1313. We will call such numbers reversible; so 36, 63, 409, and 904 are reversible.Leading zeroes are not allowed in either n or reverse(n).
        // There are 120 reversible numbers below one-thousand.
        // How many reversible numbers are there below one-billion(10^9)?

        public override int Run()
        {
            const int max = (int)1e9;

            int count = 0;

            for (int i = 1; i < max; i++)
            {
                if (i % 10 == 0)
                {
                    continue;
                }

                var reverse = Number.Reverse(i);

                var sum = reverse + i;

                if (Number.GetAllDigits(sum).All(d => d % 2 != 0))
                {
                    count++;
                }
            }

            return count;
        }
    }
}