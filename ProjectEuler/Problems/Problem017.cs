using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    // If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    // If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    // NOTE: Do not count spaces or hyphens.For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.The use of "and" when writing out numbers is in compliance with British usage.

    public class Problem017 : Problem<int>
    {
        private readonly Dictionary<int, string> _numberCount = new Dictionary<int, string>
        {
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            {20, "twenty"},
            {30, "thirty"},
            {40, "forty"},
            {50, "fifty"},
            {60, "sixty"},
            {70, "seventy"},
            {80, "eighty"},
            {90, "ninety"},
            {100, "hundred"},
            {1000, "onethousand"}
        };

        private const string And = "and";

        public override int Run()
        {
            return Enumerable.Range(1, 1000).Select(GetCharacters).Select(s => s.Length).Sum();
        }

        private string GetCharacters(int number)
        {
            if (number == 1000)
            {
                return _numberCount[number];
            }

            if (number <= 99)
            {
                return GetStringForNumbersLeesThanHundred(number);
            }

            var h = number / 100;
            var t = number - h * 100;

            if (t == 0) // one hundred, three hundred
            {
                return _numberCount[h] + _numberCount[100];
            }

            return _numberCount[h] + _numberCount[100] + And + GetStringForNumbersLeesThanHundred(t);
        }

        private string GetStringForNumbersLeesThanHundred(int number)
        {
            if (number > 99) throw new ArgumentOutOfRangeException(nameof(number));

            if (_numberCount.ContainsKey(number))
            {
                return _numberCount[number];
            }

            var f = number / 10 * 10;
            var s = number % 10;

            return _numberCount[f] + _numberCount[s];
        }
    }
}