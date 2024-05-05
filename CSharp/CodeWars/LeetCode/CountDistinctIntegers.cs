public class Solution {
    public int CountDistinctIntegers(int[] nums) {
        int[] arr = new int[nums.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            string temp = new string(nums[i].ToString().Reverse().ToArray());
            arr[i] = int.Parse(temp);
        }
        
        return arr.Concat(nums).Distinct().ToArray().Length;
    }
}