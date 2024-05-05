public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int[] result = new int[nums.Length];
        int evenIndex = 0, oddIndex = 1;

        for (int i = 0; i < nums.Length; i++) 
        {
            if (nums[i] % 2 == 0)
            {
                result[evenIndex] = nums[i];
                evenIndex += 2;
            }
            else
            {
                result[oddIndex] = nums[i];
                oddIndex += 2;
            }
        }

        return result;
    }
}