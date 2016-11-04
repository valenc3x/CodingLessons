// answer found when the same location is accesed twice
// Status: Accepted
public class Solution {
    public int FindDuplicate(int[] nums) {
        bool [] finds = new bool[nums.Length];
        for(int i=0; i<nums.Length;i++){
            if ( !finds[ nums[i] ] ){
                finds[ nums[i] ] = true;
            } else {
                return nums[i];
            }
        }
        return -1;
    }
}