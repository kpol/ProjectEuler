namespace ProjectEuler.Problems
{
    public class Problem009 : Problem<ulong>
    {
        public override ulong Run()
        {
            // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
            // a^2 + b^2 = c^2
            // For example, 3^2 + 4^2 = 9 + 16 = 25 = 52.
            // There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            // Find the product abc.

            for (ulong a = 1; a < ulong.MaxValue; a++)
            {
                for (ulong b = a + 1; b < 1000 - a; b++)
                {
                    var c = 1000 - a - b;

                    if (a * a + b * b == c * c)
                    {
                        return a * b * c;
                    }
                }
            }

            return 0;
        }
    }
}