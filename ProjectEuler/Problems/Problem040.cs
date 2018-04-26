using System.Text;

namespace ProjectEuler.Problems
{
    public class Problem040 : Problem<int>
    {
        // An irrational decimal fraction is created by concatenating the positive integers:

        // 0.123456789101112131415161718192021...

        // It can be seen that the 12th digit of the fractional part is 1.

        // If dn represents the nth digit of the fractional part, find the value of the following expression.

        // d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000

        public override int Run()
        {
            var d = new StringBuilder();

            int i = 1;

            while (d.Length < 1000000)
            {
                d.Append(i);
                i++;
            }

            return GetNumber(d, 1) * GetNumber(d, 10) * GetNumber(d, 100) * GetNumber(d, 1000) * GetNumber(d, 10000) * GetNumber(d, 100000) * GetNumber(d, 1000000);
        }

        private static int GetNumber(StringBuilder b, int index)
        {
            return int.Parse(b[index - 1].ToString());
        }
    }
}