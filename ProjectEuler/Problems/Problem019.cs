using System;

namespace ProjectEuler.Problems
{
    public class Problem019 : Problem<int>
    {
        public override int Run()
        {
            // How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

            var start = new DateTime(1901, 1, 1);
            var end = new DateTime(2000, 12, 31);

            var count = 0;

            for (var i = start; i <= end; i = i.AddMonths(1))
            {
                if (i.DayOfWeek == DayOfWeek.Sunday)
                {
                    count++;
                }
            }

            return count;
        }
    }
}