// 1877. Minimize Maximum Pair Sum in Array
public class Solution {
    public int MinPairSum(int[] nums) {
        Array.Sort(nums);
        List<int> ans = new List<int>();

        for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
            ans.Add(nums[i] + nums[j]);

        return ans.Max();
    }
}