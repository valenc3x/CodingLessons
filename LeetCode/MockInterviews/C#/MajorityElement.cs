using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode
{
    public class MajorityElement
    {
        public static int MElement(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i=0; i<nums.Length; i++) {
                if (dict.ContainsKey(nums[i])) {
                    dict[nums[i]] = dict[nums[i]] + 1;
                }else {
                    dict.Add(nums[i], 1);
                }
            }
            int threshold = nums.Length/2;
            int response = nums[0];
            foreach (int entry in dict.Keys) {
                if (dict[entry] > threshold){
                    response = entry;
                    return response;
                }
            }
            return response;
        }

        public static void Main()
        {
            int[] array = new int[]{1, 1, 1, 3, 4};
            Console.WriteLine( MElement(array) );
        }
    }
}
