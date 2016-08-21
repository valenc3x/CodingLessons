namespace LeetCode
{
    class SpiralMatrix
    {
        static void PrintMatrix(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                System.Console.Write("[");
                for (int j = 0; j < size; j++)
                {
                    System.Console.Write(" "+matrix[i, j]+" ");
                }
                System.Console.WriteLine("]");
            }
        }

        static int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n,n];
            int sideSize = n - 1;
            int number = 1;
            int i = 0;
            int j = 0;
            int loop = 0;
            // fill first row
            for ( ; j < n; j++)
            {
                matrix[i, j] = number++;
            }
            j--;
            // loop for sideSize
            for ( ; sideSize > 0; sideSize--)
            {
                for ( loop = 0 ; loop < sideSize; loop++)
                {
                    matrix[++i, j] = number++;
                }
                for ( loop = 0; loop < sideSize; loop++)
                {
                    matrix[i, --j] = number++;
                }
                sideSize--;
                for ( loop = 0; loop < sideSize; loop++)
                {
                    matrix[--i, j] = number++;
                }
                for ( loop = 0; loop < sideSize; loop++)
                {
                    matrix[i, ++j] = number++;
                }
            }
            return matrix;
        }

        static void Main(string[] args)
        {
            int size = 6;
            int[, ] result = GenerateMatrix(size);
            PrintMatrix(result, size);
        }
    }
}