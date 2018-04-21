using System;
using System.IO;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem099 : Problem<int>
    {
        // Comparing two numbers written in index form like 2^11 and 3^7 is not difficult, as any calculator would confirm that 2^11 = 2048 < 3^7 = 2187.
        // However, confirming that 632382^518061 > 519432^525806 would be much more difficult, as both numbers contain over three million digits.
        // Using base_exp.txt(right click and 'Save Link/Target As...'), a 22K text file containing one thousand lines with a base/exponent pair on each line, determine which line number has the greatest numerical value.
        // NOTE: The first two lines in the file represent the numbers in the example given above.

        public override int Run()
        {
            var lineNumber = File.ReadAllLines(@"Data\p099_base_exp.txt")
                .Select((s, i) => new { LineNumber = i + 1, Values = s.Split(',') })
                .Select(x => new { x.LineNumber, Base = long.Parse(x.Values[0]), Exp = long.Parse(x.Values[1]) })
                .Select(x => new { x.LineNumber, Value = GetValue(x.Base, x.Exp) })
                .MaxBy(x => x.Value)
                .LineNumber;

            return lineNumber;
        }

        private static long GetValue(long @base, long exp)
        {
            return (long)(exp * Math.Log(@base));
        }
    }
}