public class Solution {
    public int FindNonMinOrMax(int[] nums) {
        if (nums.Length <= 2)
            return -1;

        int maxValue = nums.Max();
        int minValue = nums.Min();

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] > minValue && nums[i] < maxValue)
                return nums[i];

        return -1;
    }
}