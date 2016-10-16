using System;

namespace LeetCode
{
    public class RemoveDuplicates
    {
        public static int Remove(int[] nums){
            int last = Int32.MinValue;
            int copy = 0;
            bool twice = false;
            for (int i=0; i<nums.Length; i++)
            {
                if (nums[i] == last)
                {
                    if (!twice) {
                        twice = true;
                    }else {
                        copy--;
                    }
                }else {
                    twice = false;
                }
                nums[copy++] = nums[i];
                last = nums[i];
            }
            return copy+1;
        }
    }
}
