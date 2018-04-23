﻿using System;
using ProjectEuler.Common;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            long sum = 0;

            for (long i = 2; i < 1000000; i++)
            {
                if (CheckNumber(i))
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }

        private static bool CheckNumber(long number)
        {
            long sum = 0;

            foreach (var digit in Number.GetAllDigits(number))
            {
                sum += digit * digit * digit * digit * digit;

                if (sum > number)
                {
                    return false;
                }
            }

            return sum == number;
        }
    }
}