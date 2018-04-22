using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem007 : Problem<int>
    {
        public override int Run()
        {
            // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            // What is the 10 001st prime number?

            return Prime.GetPrimeNumbersInt(int.MaxValue).Take(10001).Last();
        }
    }
}