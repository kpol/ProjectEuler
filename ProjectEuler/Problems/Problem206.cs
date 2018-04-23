using System;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem206 : Problem<long>
    {
        // Find the unique positive integer whose square has the form 1_2_3_4_5_6_7_8_9_0,
        // where each “_” is a single digit.

        public override long Run()
        {
            long min = (long)Math.Sqrt(1020304050607080900);

            while (true)
            {
                if (CheckDigits(min * min))
                {
                    return min;
                }

                min += 10;
            }
        }

        private static bool CheckDigits(long number)
        {
            var digits = Number.GetAllDigits(number).ToList();

            using (var e = digits.GetEnumerator())
            {
                e.MoveNext();

                if (e.Current != 0)
                {
                    return false;
                }

                for (int i = 9; i >= 1; i--)
                {
                    e.MoveNext();
                    e.MoveNext();

                    if (e.Current != i)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}