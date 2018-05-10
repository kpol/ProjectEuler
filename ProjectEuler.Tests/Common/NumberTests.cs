using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler.Common;

namespace ProjectEuler.Tests.Common
{
    [TestClass]
    public class NumberTests
    {
        [TestMethod]
        public void Number_GetAllDivisors()
        {
            const int max = 10000;

            var primes = Prime.GetPrimeNumbersIntPreCalc(max).ToList();

            for (int i = 1; i <= max; i++)
            {
                var divisors1 = Number.GetDivisors(i, false).ToList();
                var divisors2 = Number.GetAllDivisors(i, primes);

                CollectionAssert.AreEquivalent(divisors1, divisors2);
            }
        }
    }
}
