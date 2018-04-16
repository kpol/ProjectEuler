using System.Numerics;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem015 : Problem<BigInteger>
    {
        // Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        // How many such routes are there through a 20×20 grid?

        public override BigInteger Run()
        {
            // https://en.wikipedia.org/wiki/Lattice_path

            var result = Factorial.GetFactorial(40) / (Factorial.GetFactorial(20) * Factorial.GetFactorial(20));

            return result;
        }
    }
}