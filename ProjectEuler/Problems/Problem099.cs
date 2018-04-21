using System;
using System.IO;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem099 : Problem<int>
    {
        public override int Run()
        {
            var z = File.ReadAllLines(@"Data\p099_base_exp.txt");
            Console.WriteLine(z[171]);

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