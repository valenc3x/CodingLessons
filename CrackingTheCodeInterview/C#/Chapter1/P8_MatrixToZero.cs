using System;

namespace Chapter1
{
    public class MatrixToZero{
        public static int[][] ToZero(int[][] matrix){
            bool[] rows = new bool[matrix.Length];
            bool[] cols = new bool[matrix[0].Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        rows[i] = true;
                        cols[j] = true;
                    }
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (rows[i] || cols[j])
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
            return matrix;
        }

        public static void Main(){
            int[][] matrix = new int[][]
            {
                new int[]{1, 2, 5, 8},
                new int[]{3, 4, 3, 0},
                new int[]{0, 6, 1, 7},
                new int[]{5, 6, 8, 7}
            };
            matrix = ToZero(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    System.Console.Write(matrix[i][j]);
                }
                System.Console.WriteLine();
            }
        }
    }
}