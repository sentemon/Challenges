public class Solution {
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        if (nums.Length >= 1 && nums[0] == 1)
            return 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i + 1] - nums[i] != 1)
                return i + 1;
        }

        return nums.Length; 
    }
}