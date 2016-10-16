using System;

namespace MaxSumBelow
{
    public class MaxSumBelow
    {
        public static int MaxSum(int [][] matrix)
        {
            int column = 0;
            int row = 0;
            int sum = matrix[row][column];
            int limit = matrix[0].Length-1;
            while ( row<limit && column<limit )
            {
                if ( matrix[row+1][column] > matrix[row][column+1] )
                {
                    row++;
                }else {
                    column++;
                }
                sum += matrix[row][column];
            }
            return sum;
        }

        public static void Main()
        {
            int[][] matrix = new int[][]{
                new int[] {1, 2, 3, 4},
                new int[] {1, 8, 4, 0},
                new int[] {1, 9, 5, 5},
                new int[] {1, 2, 3, 7},
            };
            Console.WriteLine(MaxSum(matrix));
        }
    }
}
