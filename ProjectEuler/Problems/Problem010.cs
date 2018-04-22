using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem010 : Problem<ulong>
    {
        public override ulong Run()
        {
            // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            // Find the sum of all the primes below two million.

            ulong result = 0;

            foreach (var prime in Prime.GetPrimeNumbersULong(2000000 - 1))
            {
                result += prime;
            }

            return result;
        }
    }
}