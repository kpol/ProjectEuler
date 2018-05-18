namespace ProjectEuler.Problems
{
    /// <summary>
    /// <see cref="Problem031"/>.
    /// </summary>
    public class Problem076 : Problem<int>
    {
        // It is possible to write five as a sum in exactly six different ways:
           
        // 4 + 1
        // 3 + 2
        // 3 + 1 + 1
        // 2 + 2 + 1
        // 2 + 1 + 1 + 1
        // 1 + 1 + 1 + 1 + 1
           
        // How many different ways can one hundred be written as a sum of at least two positive integers?

        public override int Run()
        {
            int target = 100;

            var arr = new int[target];

            for (int i = 1; i < target; i++)
            {
                for (int n = i; n <= target; n++)
                {
                    if (n == i)
                    {
                        arr[n - 1]++;
                    }
                    else
                    {
                        var x = n - i;
                        arr[n - 1] += arr[x - 1];
                    }
                }
            }

            return arr[target - 1];
        }
    }
}