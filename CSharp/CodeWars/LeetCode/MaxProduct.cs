public class Solution {
    public int MaxProduct(int[] nums) {
        Array.Sort(nums);
        int[] maxValues = nums[^2..];

        return (maxValues[0] - 1) * (maxValues[1] - 1);
    }
}
