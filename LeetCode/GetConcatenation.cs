public class Solution {
    public int[] GetConcatenation(int[] nums) {
        return nums.Concat(nums).ToArray();
    }
}