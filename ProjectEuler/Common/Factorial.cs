using System.Numerics;

namespace ProjectEuler.Common
{
    public static class Factorial
    {
        public static BigInteger GetFactorial(int number)
        {
            var result = new BigInteger(1);

            for (int i = 1; i <= number; i++)
            {
                result *= new BigInteger(i);
            }

            return result;
        }
    }
}