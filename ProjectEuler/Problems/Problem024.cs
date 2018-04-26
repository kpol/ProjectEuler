using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem024 : Problem<long>
    {
        // A permutation is an ordered arrangement of objects.For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order.The lexicographic permutations of 0, 1 and 2 are:
        // 012   021   102   120   201   210
        // What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?

        public override long Run()
        {
            return Enumerable.Range(0, 10).GetAllPermutations().Select(p => long.Parse(string.Concat(p))).OrderBy(n => n)
                .Skip(999999).First();
        }
    }
}