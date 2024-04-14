public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        int[] result = new int[nums.Length];
        int evenIndex = 0, oddIndex = nums.Length - 1;

        for (int i = 0; evenIndex <= oddIndex; i++) 
        {
            if (nums[i] % 2 == 0)
                result[evenIndex++] = nums[i]; 
            else
                result[oddIndex--] = nums[i];   
        }
        
        return result;
    }
}