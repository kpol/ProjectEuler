using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem095 : Problem<int>
    {
        // The proper divisors of a number are all the divisors excluding the number itself.For example, the proper divisors of 28 are 1, 2, 4, 7, and 14. As the sum of these divisors is equal to 28, we call it a perfect number.
        // Interestingly the sum of the proper divisors of 220 is 284 and the sum of the proper divisors of 284 is 220, forming a chain of two numbers. For this reason, 220 and 284 are called an amicable pair.
        // Perhaps less well known are longer chains.For example, starting with 12496, we form a chain of five numbers:
        // 12496 → 14288 → 15472 → 14536 → 14264 (→ 12496 → ...)
        // Since this chain returns to its starting point, it is called an amicable chain.
        // Find the smallest member of the longest amicable chain with no element exceeding one million.

        private const int Max = 1000000;

        public override int Run()
        {
            var current = new SmallestCount();

            for (int i = 3; i <= Max; i++)
            {
                var r = GetSmallestAndCount(i);

                if (r.Count > current.Count)
                {
                    current.Count = r.Count;
                    current.Smallest = r.Smallest;
                }
            }

            return current.Smallest;
        }

        private static SmallestCount GetSmallestAndCount(int number)
        {
            var chain = GetChain(number);

            if (!IsAmicableChain(chain))
            {
                return new SmallestCount();
            }

            var smallest = chain[0];
            var count = 1;

            for (int i = 1; i < chain.Count; i++)
            {
                count++;

                if (chain[i] < smallest)
                {
                    smallest = chain[i];
                }
            }

            return new SmallestCount { Smallest = smallest, Count = count };
        }

        private static bool IsAmicableChain(IList<int> chain)
        {
            return chain[0] == chain[chain.Count - 1];
        }

        private static IList<int> GetChain(int number)
        {
            var set = new List<int> { number };

            var n = GetNextNumber(number);

            if (n > Max)
            {
                return set;
            }

            while (!set.Contains(n))
            {
                set.Add(n);

                n = GetNextNumber(n);

                if (n > Max)
                {
                    return set;
                }
            }

            set.Add(n);

            return set;
        }

        private static int GetNextNumber(int number)
        {
            var divisorsSum = Number.GetDivisors(number).Sum();

            return (int)divisorsSum;
        }

        private struct SmallestCount
        {
            public int Smallest { get; set; }

            public int Count { get; set; }
        }
    }
}