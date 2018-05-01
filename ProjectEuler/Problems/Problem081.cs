using System;
using System.IO;
using System.Linq;
using ProjectEuler.Common;

namespace ProjectEuler.Problems
{
    // Find the minimal path sum, in matrix.txt (right click and "Save Link/Target As..."), a 31K text file containing a 80 by 80 matrix, from the top left to the bottom right by only moving right and down.

    public class Problem081 : Problem<int>
    {
        public override int Run()
        {
            var matrix = GetMatrix();

            var length = matrix.GetLength(0);

            for (int i = length - 1; i >= 0; i--)
            {
                for (int j = length - 1; j >= 0; j--)
                {
                    if (i == j && i == length - 1)
                    {
                        continue;
                    }

                    if (i == length - 1)
                    {
                        matrix[i, j] += matrix[i, j + 1];
                    }
                    else if (j == length - 1)
                    {
                        matrix[i, j] += matrix[i + 1, j];
                    }
                    else
                    {
                        matrix[i, j] += Number.GetMin(matrix[i + 1, j], matrix[i, j + 1]);
                    }
                }
            }

            return matrix[0,0];
        }

        private static int[,] GetMatrix()
        {
            var matrixString = File.ReadAllText(@"Data\p081_matrix.txt");

            var lines = matrixString.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);

            var array = new int[lines.Length, lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                var values = lines[i].Split(',').Select(int.Parse);

                int j = 0;

                foreach (var n in values)
                {
                    array[i, j] = n;
                    j++;
                }
            }

            return array;
        }
    }
}