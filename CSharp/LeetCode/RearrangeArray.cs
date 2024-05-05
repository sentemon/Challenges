public class Solution {
    public int[] RearrangeArray(int[] nums)
    {
        int[] ans = new int[nums.Length];
        int posIndex = 0, negIndex = 1;

        for (int i = 0; i < ans.Length; i++)
        {
            if (nums[i] > 0)
            {
                ans[posIndex] = nums[i];
                posIndex += 2;
            }

            else
            {
                ans[negIndex] = nums[i];
                negIndex += 2;
            }
        }

        return ans;
    }
}