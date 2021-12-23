using System.Collections.Generic;
using System.Linq;

namespace Tic_tac_toe.Domain.Extensions
{
    public static class ListExtensions
    {
        public static T[] GetColumn<T>(this T[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public static T[] GetRow<T>(this T[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }

        public static T[] GetDiagonal<T>(this T[,] matrix, string axis = "x")
        {
            List<T> response = new();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Main diagonal
                if (axis == "x")
                    response.Add(matrix[i, i]);
                else
                {
                    int position = (matrix.GetLength(0) - 1) - i;

                    response.Add(matrix[i, position]);
                }
            }

            return response.ToArray();
        }
    }
}
