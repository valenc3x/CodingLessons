
namespace Chapter1
{
    class RotateArray
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]{
                {0, 1, 1, 1},
                {2, 0, 2, 2},
                {3, 3, 0, 3},
                {4, 4, 4, 0}
            };

            matrix = Rotate(matrix);
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write(matrix[i,j]);
                }
                System.Console.WriteLine();
            }
        }

        public static int[,] Rotate(int[,] matrix){
            int h = matrix.GetLength(0);
            int w = matrix.GetLength(1);
            int [,] r = new int[w, h];

            for (int i = 0; i < r.GetLength(0); i++)
            {
                for (int j = 0; j < r.GetLength(1); j++)
                {
                    r[i,j] = matrix[h-1-j, i];
                }
            }

            return r;
        }
    }
}