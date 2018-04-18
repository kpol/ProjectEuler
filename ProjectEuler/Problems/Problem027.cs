using System;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem027 : Problem<int>
    {
        public override int Run()
        {
            var countProduct = new Tuple<int, int>(0, 0);

            for (int a = -999; a <= 999; a++)
            {
                for (int b = -1000; b <= 1000; b++)
                {
                    int count = 0;
                    for (int n = 0; n < int.MaxValue; n++)
                    {
                        var res = n * n + a * n + b;

                        if (res < 0 || !Prime.IsPrime((ulong)res))
                        {
                            if (countProduct.Item1 < count)
                            {
                                countProduct = new Tuple<int, int>(count, a * b);
                            }

                            break;
                        }

                        count++;
                    }
                }
            }

            return countProduct.Item2;
        }
    }
}