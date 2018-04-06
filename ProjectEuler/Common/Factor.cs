using System;

namespace ProjectEuler.Common
{
    public static class Factor
    {
        public static int GetFactorsCount(uint number)
        {
            var count = 2;

            var end = (uint)Math.Sqrt(number);

            for (int i = 2; i <= end; i++)
            {
                if (number % i == 0)
                {
                    count += 2;
                }
            }

            if (end * end == number)
            {
                count--;
            }

            return count;
        }
    }
}