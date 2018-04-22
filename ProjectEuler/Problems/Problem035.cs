using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem035 : Problem<int>
    {
        public override int Run()
        {
            // The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
            // There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
            // How many circular primes are there below one million?

            var count = Prime.GetPrimeNumbers(1000000 - 1).Count(p => Number.GetAllRotations(p).All(Prime.IsPrime));

            return count;
        }
    }
}
