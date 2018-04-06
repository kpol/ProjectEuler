using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Common;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            uint max = 1000000;

            var primes = new HashSet<ulong>(Prime.GetPrimeNumbers(max - 1));


        }
    }
}