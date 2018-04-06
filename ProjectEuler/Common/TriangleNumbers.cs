using System.Collections.Generic;

namespace ProjectEuler.Common
{
    public static class TriangleNumbers
    {
        public static IEnumerable<uint> GetTriangleNumbers(uint number)
        {
            uint sum = 0;

            for (uint i = 1; i <= number; i++)
            {
                sum += i;

                yield return sum;
            }
        }
    }
}