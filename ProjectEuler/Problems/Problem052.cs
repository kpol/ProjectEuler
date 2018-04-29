using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    // It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
    // Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.

    public class Problem052 : Problem<int>
    {
        public override int Run()
        {
            for (int i = 1; i < int.MaxValue; i++)
            {
                if (Number.IsPermutation(i, 2 * i)
                    && Number.IsPermutation(i, 3 * i)
                    && Number.IsPermutation(i, 4 * i)
                    && Number.IsPermutation(i, 5 * i)
                    && Number.IsPermutation(i, 6 * i))
                {
                    return i;
                }
            }

            return 0;
        }
    }
}