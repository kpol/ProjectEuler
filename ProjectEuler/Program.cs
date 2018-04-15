using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using ProjectEuler.Common;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var i in Prime.GetPrimeFactors(81))
            {
                Console.WriteLine(i);
            }
        }
    }
}