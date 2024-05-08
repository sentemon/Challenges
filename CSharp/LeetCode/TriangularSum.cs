// 2221. Find Triangular Sum of an Array
public class Solution {
    public int TriangularSum(int[] nums) {
        if (nums.Length == 1)
            return nums[0];

        int[] arr = new int[nums.Length - 1];

        for (int i = 0; i < arr.Length; i++)
            arr[i] = (nums[i] + nums[i+1]) % 10;

        return TriangularSum(arr);
    }
}