namespace ProjectEuler.Problems
{
    public class Problem031 : Problem<int>
    {
        // In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:
           
        // 1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
        // It is possible to make £2 in the following way:
           
        // 1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
        // How many different ways can £2 be made using any number of coins?

        public int Run1()
        {
            const int max = 200;

            int count = 0;

            for (int p200 = 0; p200 <= max; p200 += 200)
            {
                for (int p100 = p200; p100 <= max; p100 += 100)
                {
                    for (int p50 = p100; p50 <= max; p50 += 50)
                    {
                        for (int p20 = p50; p20 <= max; p20 += 20)
                        {
                            for (int p10 = p20; p10 <= max; p10 += 10)
                            {
                                for (int p5 = p10; p5 <= max; p5 += 5)
                                {
                                    for (int p2 = p5; p2 <= max; p2 += 2)
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return count;
        }

        public override int Run()
        {
            int target = 200;
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            var arr = new int[target];

            foreach (var coin in coins)
            {
                for (int n = coin; n <= target; n++)
                {
                    if (n == coin)
                    {
                        arr[n - 1]++;
                    }
                    else
                    {
                        var x = n - coin;
                        arr[n - 1] += arr[x - 1];
                    }
                }
            }

            return arr[target - 1];
        }
    }
}