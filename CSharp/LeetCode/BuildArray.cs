public class Solution {
    public int[] BuildArray(int[] nums) {
        int[] ans = new int[nums.Length];

        for (int i = 0; i < ans.Length; i++)
            ans[i] = nums[nums[i]];

        return ans;
    }
}