public class Solution {
    public int MaximumCount(int[] nums) {
        int pos = 0;
        int neg = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                pos++;
            else if (nums[i] < 0)
                neg++;
        }

        return Math.Max(pos, neg);
    }
}