using System.Numerics;

namespace ProjectEuler.Common
{
    public static class Factorial
    {
        public static BigInteger GetFactorial(int number, int start = 1)
        {
            var result = new BigInteger(1);

            for (int i = start; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}