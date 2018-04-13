using System;

namespace ProjectEuler.Problems
{
    public class Problem039 : Problem
    {
        // If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.
        // {20,48,52}, {24,45,51}, {30,40,50}
        // For which value of p ≤ 1000, is the number of solutions maximised?

        public override void Run()
        {
            var pMax = 0;
            var maxCount = 0;

            for (int p = 3; p <= 1000; p++)
            {
                var count = 0;

                for (int a = 1; a < p; a++)
                {
                    for (int b = a; b < p - a; b++)
                    {
                        var c = p - a - b;

                        if (a * a + b * b == c * c)
                        {
                            count++;
                        }
                    }
                }

                if (maxCount < count)
                {
                    maxCount = count;
                    pMax = p;
                }
            }

            Console.WriteLine(pMax);
        }
    }
}