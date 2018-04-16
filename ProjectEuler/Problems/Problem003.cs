using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem003 : Problem<ulong>
    {
        public override ulong Run()
        {
            // The prime factors of 13195 are 5, 7, 13 and 29.
            // What is the largest prime factor of the number 600851475143?

            var result = Prime.GetPrimeFactors(600851475143).OrderByDescending(n => n).First();

            return result;
        }
    }
}