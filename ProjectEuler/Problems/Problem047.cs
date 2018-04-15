using System;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem047 : Problem
    {
        // The first two consecutive numbers to have two distinct prime factors are:
           
        // 14 = 2 × 7
        // 15 = 3 × 5
           
        // The first three consecutive numbers to have three distinct prime factors are:
           
        // 644 = 2² × 7 × 23
        // 645 = 3 × 5 × 43
        // 646 = 2 × 17 × 19.
           
        // Find the first four consecutive integers to have four distinct prime factors each.What is the first of these numbers?


        public override void Run()
        {
            for (ulong i = 100; i < ulong.MaxValue; i++)
            {
                bool found = true;

                for (ulong j = 0; j < 4; j++)
                {
                    var n = Prime.GetPrimeFactors(i + j).Distinct().Count();

                    if (n != 4)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}