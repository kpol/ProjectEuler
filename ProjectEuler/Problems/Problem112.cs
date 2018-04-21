using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem112 : Problem<int>
    {
        // Working from left-to-right if no digit is exceeded by the digit to its left it is called an increasing number; for example, 134468.
        // Similarly if no digit is exceeded by the digit to its right it is called a decreasing number; for example, 66420.
        // We shall call a positive integer that is neither increasing nor decreasing a "bouncy" number; for example, 155349.
        // Clearly there cannot be any bouncy numbers below one-hundred, but just over half of the numbers below one-thousand(525) are bouncy.In fact, the least number for which the proportion of bouncy numbers first reaches 50% is 538.
        // Surprisingly, bouncy numbers become more and more common and by the time we reach 21780 the proportion of bouncy numbers is equal to 90%.
        // Find the least number for which the proportion of bouncy numbers is exactly 99%.

        public override int Run()
        {
            int count = 0;
            int percentage = 99;
            int i;

            for (i = 1; i < int.MaxValue; i++)
            {
                if (IsBouncy(i))
                {
                    count++;

                    if (count * 100 / i == percentage)
                    {
                        break;
                    }
                }
            }

            return i;
        }

        private static bool IsBouncy(long number)
        {
            if (number < 100)
            {
                return false;
            }

            bool increasing = false;
            int i;

            var digits = Number.GetAllDigits(number).ToList();

            for (i = 1; i < digits.Count; i++)
            {
                if (digits[i - 1] < digits[i])
                {
                    increasing = true;
                    break;
                }

                if (digits[i - 1] > digits[i])
                {
                    break;
                }
            }

            for (int j = i + 1; j < digits.Count; j++)
            {
                if (increasing)
                {
                    if (digits[j - 1] > digits[j])
                    {
                        return true;
                    }
                }
                else
                {
                    if (digits[j - 1] < digits[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}