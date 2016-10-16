using System;
using System.Collections;
namespace LeetCode
{
    class SingleNumber
    {
        static void Main(string[] args)
        {
            int[] nums = new int[]{
                43,
                43,
                43,
                16,
                16,
                16,
                45,
                45,
                45,
                89,
                89,
                89,
                -2147483648,
                -2147483648,
                -2147483648,
                2147483646,
                2147483646,
                2147483646,
                -2147483646,
                -2147483646,
                -2147483646,
                -2147483647,
                -2147483647,
                -2147483647,
                2147483647,
            };
            System.Console.WriteLine(FindSingle(nums));

        }

        static int FindSingle(int[] nums)
        {
            double number = 0;
            Hashtable dict = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                number = Math.Log(nums[i], 3);
                number = (int)number ^ nums[i];
                // if (dict.ContainsKey(nums[i]))
                // {
                //     number ^= nums[i];
                //     System.Console.WriteLine(number);
                // } else {
                //     System.Console.WriteLine("d:"+nums[i]);
                //     dict.Add(nums[i], 0);
                // }
            }
            return (int)Math.Log(number, 10);
            // return (int)(number/2);
        }
    }
}
