using System;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    public class Problem018 : Problem<int>
    {
        // Find the maximum total from top to bottom of the triangle below:

        private const string TriangleString = @"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

        public override int Run()
        {
            var triangle = GetTriangle();

            var length = triangle.GetLength(0);

            // divide and conquer

            for (int i = length - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    triangle[i, j] += Number.GetMax(triangle[i + 1, j], triangle[i + 1, j + 1]);
                }
            }

            return triangle[0, 0];
        }

        private static int[,] GetTriangle()
        {
            var lines = TriangleString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var data = new int[lines.Length, lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                var numbers = lines[i].Split(' ');

                for (int j = 0; j < numbers.Length; j++)
                {
                    data[i, j] = int.Parse(numbers[j]);
                }
            }

            return data;
        }
    }
}