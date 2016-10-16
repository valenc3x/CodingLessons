using System;

namespace MockInterviews
{
    class Triangle
    {
        public static int MinimumTotal(IList<IList<int>> triangle) {
            int totalSum = triangle[0][0];
            int levels = triangle.Count;
            int lastPos = 0;
            int[] n = new int[3];
            int min;
            for (int i = 1; i < levels; i++)
            {
                if (lastPos == 0) {
                    n[0] = Int32.MaxValue;
                    n[1] = triangle[i][lastPos];
                    n[2] = triangle[i][lastPos+1];
                } else if (lastPos == triangle[i].Count-1) {
                    n[0] = triangle[i][lastPos-1];
                    n[1] = triangle[i][lastPos];
                    n[2] = Int32.MaxValue;
                } else {
                    n[0] = triangle[i][lastPos-1];
                    n[1] = triangle[i][lastPos];
                    n[2] = triangle[i][lastPos+1];
                }
                min = Int32.MaxValue;
                for (int j = 0; j < n.Length; j++)
                {
                    if(n[j] < min){
                        min = n[j];
                        lastPos = j;
                    }
                }
                totalSum += min;
            }
            return totalSum;
        }

        static void Main(string[] args)
        {

        }
    }
}
