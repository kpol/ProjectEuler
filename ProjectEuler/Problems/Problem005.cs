using System;

namespace ProjectEuler.Problems
{
    public static class Problem005
    {
        public static void Run()
        {
            // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?

            // 232792560

            // 2 * 2 * 2 * 2
            int n = 16;

            // 3 * 3
            var t = 9;

            int[] prime = { 1, 5, 7, 11, 13, 17, 19 };
            int res = 1;

            foreach (var i in prime)
            {
                res *= i;
            }

            res *= n;
            res *= t;

            Console.WriteLine(res);
        }
    }
}