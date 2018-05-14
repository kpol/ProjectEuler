using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using ProjectEuler.Common;
using ProjectEuler.Problems;

namespace ProjectEuler
{
    public class Program
    {
        const int Max = 110000000;
        //const int Max = 1000000;

        public static void Main(string[] args)
        {
            // a = 3k + 2
            // b * c^2 = (k + 1)^2 * (8k + 5) = x
            PP();
            int count = 0;

            var sw = new Stopwatch();
            sw.Start();

            for (long k = 0; k < Max / 6; k++)
            {
                var a = 3 * k + 2;

                count += X2(k, a);
            }
            sw.Stop();

            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine(count);
        }

        private static void PP()
        {
            int N = 1000000;

            Console.Out.WriteLine(
                Enumerable.Range(0, N / 6).Select(m => (long)m).Sum(m =>
                {
                    long count = 0;
                    long a = 3 * m + 2;
                    long t2 = 8 * m + 5;

                    long d = ((long)Math.Sqrt(t2) / 2) * 2 + 1;
                    for (; d > 1 && t2 % (d * d) != 0; d -= 2) ;
                    t2 /= (d * d);

                    long t1 = (m + 1) * d;
                    for (long b = (long)Math.Sqrt(t1); b >= 1; b--)
                    {
                        if (t1 % b == 0)
                        {
                            if (a + b + (decimal)t2 * (t1 / b) * (t1 / b) <= N)
                                count++;

                            if (t1 / b != b && a + t1 / b + (decimal)t2 * b * b <= N)
                                count++;
                        }
                    }
                    return count;
                }));

        }


        private static int X(long k, ICollection<int> primes, long a)
        {
            var bb = k + 1;
            var cc = 8 * k + 5;

            var div1 = Number.GetAllDivisors(bb, primes);
            div1.Sort((i, j) => (int)(j - i));

            var div2 = Number.GetAllDivisors(cc, primes);
            div2.Sort();

            var set = new HashSet<Tuple<long, long>>();

            foreach (var d2 in div2)
            {
                var sqrt = (long)Math.Sqrt(d2);

                if (a + sqrt >= Max)
                {
                    return set.Count;
                }

                if (a + sqrt + cc / d2 > Max)
                {
                    continue;
                }

                if (sqrt * sqrt == d2)
                {
                    foreach (var d1 in div1)
                    {
                        var b = bb * sqrt / d1;

                        if (a + b >= Max)
                        {
                            break;
                        }

                        var c = cc * d1 * d1 / d2;

                        if (a + b + c <= Max)
                        {
                            set.Add(new Tuple<long, long>(b, c));
                        }
                    }
                }
            }

            return set.Count;
        }

        private static long GetLargestSquareDivisor(long n)
        {
            long d;

            for (d = (long)Math.Sqrt(n) / 2 * 2 + 1; d > 1 && n % (d * d) != 0; d -= 2)
            {

            }

            return d;
        }

        private static int X2(long k, long a)
        {
            var bb = k + 1;
            var cc = 8 * k + 5;

            var count = 0;

            long maxSquare = GetLargestSquareDivisor(cc);

            cc /= maxSquare * maxSquare;

            var bbMax = bb * maxSquare;

            var z = (long)Math.Sqrt(bbMax);

            for (int b = 1; b <= z; b++)
            {
                if (bbMax % b == 0)
                {
                    var cTmp = (decimal)cc * bbMax / b * bbMax / b;

                    if (a + b + cTmp <= Max)
                    {
                        count++;
                    }

                    var bTmp = bbMax / b;
                    cTmp = (decimal)cc * b * b;

                    if (b != bTmp && a + bTmp + cTmp <= Max)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static int Y(long k, long a)
        {
            var x = (k + 1) * (k + 1) * (8 * k + 5);

            int count = 0;

            for (long b = 1; a + b < Max; b++)
            {
                if (x % (b * b) == 0)
                {
                    var c = x / (b * b);

                    if (a + b + c <= Max)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private static int Y(long k, ICollection<int> primes, long a)
        {
            var x = (k + 1) * (k + 1) * (8 * k + 5);

            int count = 0;



            for (long b = 1; a + b < Max; b++)
            {
                if (x % (b * b) == 0)
                {
                    var c = x / (b * b);

                    if (a + b + c <= Max)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}