using System;
using System.Collections;
namespace LeetCode
{
    class SingleNumber
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{7, 6, 4, 4, 6, 7, 6, 7, 4, 2};
            System.Console.WriteLine(FindSingle(nums));
        }

        static int FindSingle(int[] nums)
        {
            int number = 0;
            Hashtable dict = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {

                    number -= (int)dict[nums[i]];
                } else {
                    System.Console.WriteLine("p"+nums[i]);
                    dict.Add(nums[i], 0);
                    number += (2*nums[i]);
                }
                System.Console.WriteLine("n"+number);
            }
            System.Console.WriteLine("c:"+dict.Count);
            return number/2;
        }
    }
}