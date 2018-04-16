using System.IO;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem022 : Problem<int>
    {
        // Using names.txt(right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
        // For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.So, COLIN would obtain a score of 938 × 53 = 49714.
        // What is the total of all the name scores in the file?

        public override int Run()
        {
            var names = File.ReadAllText(@"Data\p022_names.txt").Split(',').Select(n => n.Trim('"')).OrderBy(n => n).ToArray();

            var total = 0;

            for (int i = 0; i < names.Length; i++)
            {
                var sum = names[i].Select(c => c - 64).Sum();

                total += (i + 1) * sum;
            }

            return total;
        }
    }
}