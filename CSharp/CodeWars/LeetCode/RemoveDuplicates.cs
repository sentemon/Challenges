public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null || nums.Length == 0)
            return 0;

        int uniqueCount = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i - 1]) {
                nums[uniqueCount] = nums[i];
                uniqueCount++;
            }
        }

        return uniqueCount;
    }
}