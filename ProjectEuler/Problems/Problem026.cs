using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public class Problem026 : Problem<int>
    {
        // A unit fraction contains 1 in the numerator.The decimal representation of the unit fractions with denominators 2 to 10 are given:
           
        // 1/2	= 	0.5
        // 1/3	= 	0.(3)
        // 1/4	= 	0.25
        // 1/5	= 	0.2
        // 1/6	= 	0.1(6)
        // 1/7	= 	0.(142857)
        // 1/8	= 	0.125
        // 1/9	= 	0.(1)
        // 1/10	= 	0.1
        // Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle.It can be seen that 1/7 has a 6-digit recurring cycle.

        // Find the value of d< 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.

        public override int Run()
        {
            int max = 0;
            int d = 0;

            for (int i = 1; i < 1000; i++)
            {
                var length = GetCycleLength(1, i);

                if (max < length)
                {
                    max = length;
                    d = i;
                }
            }

            return d;
        }

        private static int GetCycleLength(int n, int d)
        {
            var remainders = new HashSet<int>();

            int remainder;

            while ((remainder = GetReminder(n, d)) != 0 && !remainders.Contains(remainder))
            {
                remainders.Add(remainder);
                n = remainder;
            }

            if (remainder == 0)
            {
                return remainders.Count + 1;
            }

            return remainders.Count;
        }

        private static int GetReminder(int n, int d)
        {
            while (n % d == n)
            {
                n *= 10;
            }

            return n % d;
        }
    }
}