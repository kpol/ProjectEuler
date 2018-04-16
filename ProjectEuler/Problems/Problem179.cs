namespace ProjectEuler.Problems
{
    public class Problem179 : Problem<int>
    {
        // Find the number of integers 1 < n < 10^7, for which n and n + 1 have the same number of positive divisors.For example, 14 has the positive divisors 1, 2, 7, 14 while 15 has 1, 3, 5, 15.

        private const int Max = 10000000;

        public override int Run()
        {
            // do not include 0

            var numberOfDivisors = new int[Max];

            // every number is divisible by 1
            // every second number is divisible by 2
            // every third number is divisible by 3
            // ...

            int count = 0;

            for (int i = 1; i < numberOfDivisors.Length; i++)
            {
                // we start from 1

                for (int j = i; j < numberOfDivisors.Length; j += i)
                {
                    numberOfDivisors[j]++;
                }

                if (numberOfDivisors[i] == numberOfDivisors[i - 1])
                {
                    count++;
                }
            }

            return count;
        }
    }
}