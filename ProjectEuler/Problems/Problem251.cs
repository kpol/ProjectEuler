using System;

namespace ProjectEuler.Problems
{
    public class Problem251 : Problem<int>
    {
        // Find how many Cardano Triplets exist such that a+b+c ≤ 110,000,000.

        private const int Max = 110000000;

        public override int Run()
        {
            int count = 0;

            for (long k = 0; k < Max / 6; k++)
            {
                var a = 3 * k + 2;

                count += Calc(k, a);
            }

            return count;
        }

        private static int Calc(long k, long a)
        {
            var bb = k + 1;
            var cc = 8 * k + 5;

            var count = 0;

            long maxSquare = GetLargestSquareDivisor(cc);

            cc /= maxSquare * maxSquare;

            var bbMax = bb * maxSquare;

            var z = (long)Math.Sqrt(bbMax);

            for (int b = 1; b <= z; b++)
            {
                if (bbMax % b == 0)
                {
                    var cTmp = (decimal)cc * bbMax / b * bbMax / b;

                    if (a + b + cTmp <= Max)
                    {
                        count++;
                    }

                    var bTmp = bbMax / b;
                    cTmp = (decimal)cc * b * b;

                    if (b != bTmp && a + bTmp + cTmp <= Max)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static long GetLargestSquareDivisor(long n)
        {
            long d;

            for (d = (long)Math.Sqrt(n) / 2 * 2 + 1; d > 1 && n % (d * d) != 0; d -= 2)
            {

            }

            return d;
        }
    }
}