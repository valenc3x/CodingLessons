using System;

namespace GeeksForGeeks
{
    public class TheCelebrityProblem
    {
        static int Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int []{0, 0, 1, 1},
                new int []{1, 0, 1, 0},
                new int []{1, 0, 0, 1},
                new int []{0, 0, 1, 0}
            };

            System.Console.WriteLine(getID(matrix, 4));
            return 0;
        }

        static int getID(int[][] M, int n)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (M[i][j] == 1)
                    {
                        bool flag = true;
                        for (int k = 0; k < n; k++)
                        {
                            if (k == j)
                            {
                                continue;
                            }
                            flag &= M[k][j] == 1;
                        }
                        if (flag)
                        {
                            return j;
                        }
                    }
                }
            }
            return -1;
        }
    }
}