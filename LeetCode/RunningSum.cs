public class Solution {
    public int[] RunningSum(int[] nums) {
        int[] ans = new int[nums.Length];
        int sum = 0;

        for (int i = 0; i < ans.Length; i++)
        {
            sum += nums[i];
            ans[i] = sum;
        }

        return ans;
    }
}