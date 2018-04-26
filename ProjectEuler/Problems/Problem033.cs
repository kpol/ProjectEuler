using System;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem033 : Problem<int>
    {
        // The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
        // We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
        // There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
        // If the product of these four fractions is given in its lowest common terms, find the value of the denominator.

        public override int Run()
        {
            var list = new List<Tuple<int, int>>(4);

            for (int i = 10; i < 99; i++)
            {
                for (int j = i + 1; j <= 99; j++)
                {
                    var numerator = Number.GetAllDigits(i).ToList();
                    var denominator = Number.GetAllDigits(j).ToList();

                    if (numerator[0] != 0)
                    {
                        var index = denominator.IndexOf(numerator[0]);
                        if (index >= 0 && numerator[0] != 0)
                        {
                            var d1 = index == 0 ? denominator[1] : denominator[0];

                            // ReSharper disable once CompareOfFloatsByEqualityOperator
                            if ((double)numerator[1] / d1 == (double)i / j)
                            {
                                list.Add(new Tuple<int, int>(i, j));
                            }
                        }
                    }

                    if (numerator[1] != 0)
                    {
                        var index = denominator.IndexOf(numerator[1]);

                        if (index >= 0 && numerator[1] != 0)
                        {
                            var d1 = index == 0 ? denominator[1] : denominator[0];

                            // ReSharper disable once CompareOfFloatsByEqualityOperator
                            if ((double)numerator[0] / d1 == (double)i / j)
                            {
                                list.Add(new Tuple<int, int>(i, j));
                            }
                        }
                    }
                }
            }

            int numeratorResult = 1;
            int denominatorResult = 1;

            foreach (var item in list)
            {
                numeratorResult *= item.Item1;
                denominatorResult *= item.Item2;
            }

            return denominatorResult / Simplify(numeratorResult, denominatorResult);
        }

        private static int Simplify(int n, int d)
        {
            int y, x;

            if (n > d)
            {
                x = n;
                y = d;
            }
            else
            {
                x = d;
                y = n;
            }

            while (x % y != 0)
            {
                int temp = x;
                x = y;
                y = temp % x;
            }

            return y;
        }
    }
}