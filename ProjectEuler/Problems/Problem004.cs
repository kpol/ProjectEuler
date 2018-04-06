using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    public static class Problem004
    {
        public static void Run()
        {
            // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.
            // Find the largest palindrome made from the product of two 3 - digit numbers.

            for (int i = 999; i >= 100; i--)
            {
                var n = i.ToString();
                var reverse = new string(n.Reverse().ToArray());

                var r = int.Parse(n + reverse);

                for (int j = 100; j <= 999; j++)
                {
                    if (r % j == 0)
                    {
                        if ((r / j).ToString().Length == 3)
                        {
                            Console.WriteLine(r);

                            return;
                        }
                    }
                }
            }
        }
    }
}