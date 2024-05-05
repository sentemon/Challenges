public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int[] result = new int[n * 2];

        for (int i = 0; i < n; i++)
        {
            result[2 * i] = nums[i];
            result[2 * i + 1] = nums[i + n];
        }    

        return result;
    }
}