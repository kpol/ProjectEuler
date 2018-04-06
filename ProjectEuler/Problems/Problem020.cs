using System;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem020 : Problem
    {
        public override void Run()
        {
            // n!means n × (n − 1) × ... × 3 × 2 × 1

            // For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
            // and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
            // Find the sum of the digits in the number 100!

            var result = Factorial.GetFactorial(100).ToString().Select(c => int.Parse(c.ToString())).Sum();

            Console.WriteLine(result);
        }
    }
}