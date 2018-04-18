using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem038 : Problem<int>
    {
        public override int Run()
        {
            const int maxPandigital = 999999999;

            long maxFound = 0;

            for (int number = 1; number < 99999; number++)
            {
                long concatenated = 0;
                for (int n = 1; n <= maxPandigital; n++)
                {
                    concatenated = Number.ConcatenateNumbers(concatenated, n * number);

                    if (concatenated >= 111111111 && concatenated <= maxPandigital) // 9 digits number
                    {
                        if (n == 1)
                        {
                            break;
                        }

                        if (Number.IsPandigital(concatenated) && maxFound < concatenated)
                        {
                            maxFound = concatenated;
                        }
                    }
                    else if (concatenated > maxPandigital)
                    {
                        break;
                    }
                }
            }

            return (int)maxFound;
        }
    }
}