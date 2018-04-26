using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem032 : Problem<int>
    {
        // We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
        // The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
        // Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
        // HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.

        public override int Run()
        {
            var set = new HashSet<int>();

            for (int i = 1; i <= 5000; i++)
            {
                for (int j = i + 1; j <= 5000; j++)
                {
                    var numberToCheck = Number.ConcatenateNumbers(i, j, i * j);

                    if (numberToCheck >= 123456789 && numberToCheck <= 987654321 && Number.IsPandigital(numberToCheck))
                    {
                        set.Add(i * j);
                    }

                }
            }

            return set.Sum();
        }
    }
}