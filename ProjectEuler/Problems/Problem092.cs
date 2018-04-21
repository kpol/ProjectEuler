using System.Collections.Generic;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem092 : Problem<int>
    {
        // A number chain is created by continuously adding the square of the digits in a number to form a new number until it has been seen before.
        // For example,
        // 44 → 32 → 13 → 10 → 1 → 1
        // 85 → 89 → 145 → 42 → 20 → 4 → 16 → 37 → 58 → 89
        // Therefore any chain that arrives at 1 or 89 will become stuck in an endless loop.What is most amazing is that EVERY starting number will eventually arrive at 1 or 89.
        // How many starting numbers below ten million will arrive at 89?

        private readonly HashSet<long> _numbersLeadingTo89 = new HashSet<long>();

        private readonly HashSet<long> _numbersLeadingTo1 = new HashSet<long>();

        public override int Run()
        {
            int count = 0;

            for (int i = 1; i < 10000000; i++)
            {
                if (LastNumberEquals89(i))
                {
                    count++;
                }
            }

            return count;
        }

        private bool LastNumberEquals89(long number)
        {
            if (_numbersLeadingTo89.Contains(number))
            {
                return true;
            }

            if (_numbersLeadingTo1.Contains(number))
            {
                return false;
            }

            var set = new List<long> { number };

            while ((number = GetNextNumber(number)) != 0)
            {
                if (_numbersLeadingTo89.Contains(number) || number == 89)
                {
                    set.ForEach(x => _numbersLeadingTo89.Add(x));

                    return true;
                }

                if (_numbersLeadingTo1.Contains(number) || number == 1)
                {
                    set.ForEach(x => _numbersLeadingTo1.Add(x));

                    return false;
                }

                set.Add(number);
            }

            return false;
        }

        private static long GetNextNumber(long number)
        {
            long result = 0;

            foreach (var n in Number.GetAllDigits(number))
            {
                result += n * n;
            }

            return result;
        }
    }
}