using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems
{
    public class Problem016 : Problem<int>
    {
        public override int Run()
        {
            var result = BigInteger.Pow(new BigInteger(2), 1000).ToString().Select(c => int.Parse(c.ToString())).Sum();

            return result;
        }
    }
}