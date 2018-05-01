using System;

namespace ProjectEuler.Common
{
    public static class Matrix
    {
        public static int[,] GetMatrix(string matrixString, char separator = ',')
        {
            var lines = matrixString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var array = new int[lines.Length, lines[0].Split(separator).Length];

            for (int i = 0; i < lines.Length; i++)
            {
                var values = lines[i].Split(separator);

                for (int j = 0; j < values.Length; j++)
                {
                    var n = int.Parse(values[j]);
                    array[i, j] = n;
                }
            }

            return array;
        }
    }
}