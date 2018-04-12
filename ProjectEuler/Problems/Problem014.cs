using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem014 : Problem
    {
        // The following iterative sequence is defined for the set of positive integers:
           
        // n → n/2 (n is even)
        // n → 3n + 1 (n is odd)
           
        // Using the rule above and starting with 13, we generate the following sequence:
           
        // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        // It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
           
        // Which starting number, under one million, produces the longest chain?
           
        // NOTE: Once the chain starts the terms are allowed to go above one million.

        public override void Run()
        {
            int maxCount = 0;
            uint number = 0;

            for (uint i = 1; i < 1e6; i++)
            {
                var chainCount = GetChain(i).Count();

                if (chainCount > maxCount)
                {
                    maxCount = chainCount;
                    number = i;
                }
            }

            Console.WriteLine(number);
        }

        private static IEnumerable<uint> GetChain(uint start)
        {
            var current = start;

            while (current != 1)
            {
                if (current % 2 == 0)
                {
                    current /= 2;
                    yield return current;
                }
                else
                {
                    current = current * 3 + 1;
                    yield return current;
                }
            }
        }
    }
}