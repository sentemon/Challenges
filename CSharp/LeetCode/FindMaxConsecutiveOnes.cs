public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int result = 0, counter = 0;
        
        foreach (int n in nums)
        {
            counter = (n == 1) ? counter + 1 : 0;
            result = Math.Max(result, counter);
        }

        return result;
    }
}