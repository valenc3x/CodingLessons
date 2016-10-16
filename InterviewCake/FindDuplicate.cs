using System;

namespace InterviewCake
{
    public class FindDuplicate
    {
        public static int SpaceEdition(int array)
        {
            int index = -1;
            for (int i=0; i<array.Length; i++)
            {
                index = Math.Abs(array[i]-1);
                if (array[index] < 0)
                {
                    return array[index] * -1;
                }else {
                    array[index] = array[index] * -1
                }
            }
        }
    }
}
