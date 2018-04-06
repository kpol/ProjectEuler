﻿using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    public static class Problem001
    {
        public static void Run()
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.
            var result = Enumerable.Range(1, 999).Where(i => i % 3 == 0 || i % 5 == 0).Sum();

            Console.WriteLine(result);
        }
    }
}