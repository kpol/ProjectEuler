using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem042 : Problem<int>
    {
        // The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:
        // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
        // By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value.For example, the word value for SKY is 19 + 11 + 25 = 55 = t10.If the word value is a triangle number then we shall call the word a triangle word.

        public override int Run()
        {
            var wordsValues = File.ReadAllText(@"Data\p042_words.txt").Split(',').Select(s => GetWordValue(s.Trim('"'))).ToList();

            var maxValue = wordsValues.Max();

            int n = 1;

            var triangleValues = new HashSet<int>();

            while (true)
            {
                var triangleNumber = GetTriangleNumber(n);
                triangleValues.Add(triangleNumber);

                if (triangleNumber > maxValue)
                {
                    break;
                }

                n++;
            }

            return wordsValues.Count(v => triangleValues.Contains(v));
        }

        private static int GetWordValue(string word)
        {
            return word.Select(l => l - 'A' + 1).Sum();
        }

        private static int GetTriangleNumber(int n)
        {
            return (n * n + n) / 2;
        }
    }
}