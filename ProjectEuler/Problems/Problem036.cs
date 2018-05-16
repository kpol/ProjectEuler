using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem036 : Problem<int>
    {
        // The decimal number, 585 = 1001001001 (binary), is palindromic in both bases.
        // Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        // (Please note that the palindromic number, in either base, may not include leading zeros.)

        public override int Run()
        {
            var result = Enumerable.Range(1, 1000000 - 1).Where(n => Number.IsPalindrome(n) && Number.IsPalindrome(Number.GetBits(n).ToList()));

            return result.Sum();
        }
    }
}
