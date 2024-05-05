public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums)
            set.Add(num);
    
        return 2 * set.Sum() - nums.Sum();
    }
}