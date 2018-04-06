using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public static class Problem016
    {
        public static void Run()
        {
            var result = BigInteger.Pow(new BigInteger(2), 1000).ToString().Select(c => int.Parse(c.ToString())).Sum();
            Console.WriteLine(result);
        }
    }
}