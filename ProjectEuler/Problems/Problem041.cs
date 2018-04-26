using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem041 : Problem<int>
    {
        // We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once.For example, 2143 is a 4-digit pandigital and is also prime.
        // What is the largest n-digit pandigital prime that exists?

        public override int Run()
        {
            for (int i = 9; i >= 0; i--)
            {
                var pandigitalNumber = GetPandigitalNumber(i);

                if (pandigitalNumber != 0)
                {
                    return pandigitalNumber;
                }
            }

            return 0;
        }

        private static int GetPandigitalNumber(int length)
        {
            var arr = Enumerable.Range(1, length);

            var pandigitalNumbers = arr.GetAllPermutations().Select(x => int.Parse(string.Concat(x))).OrderByDescending(x => x);

            foreach (var pandigitalNumber in pandigitalNumbers)
            {
                if (Prime.IsPrime((ulong)pandigitalNumber))
                {
                    return pandigitalNumber;
                }
            }

            return 0;
        }
    }
}