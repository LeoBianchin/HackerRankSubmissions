using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class DiagonalDifference
    {
        public void Execute()
        {
            Console.WriteLine($"Digite valor:");

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference.diagonalDifference(arr);

            Console.WriteLine($"{result}");
        }

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int resultA = 0;
            int resultB = 0;

            for (var i = 0; i < arr.Count; i++)
            {
                int rows = arr[i].Count();
                for (var j = 0; j < rows; j++)
                {
                    if (i == j)
                    {
                        resultA += arr[i][j];
                    }

                    if ((i + j).Equals(rows - 1))
                    {
                        resultB += arr[i][j];
                    }
                }
            }

            return Math.Abs(resultA - resultB);
        }

    }
}
