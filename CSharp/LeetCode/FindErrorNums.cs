// 645. Set Mismatch
public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int n = nums.Length;
        
        int expectedSum = n * (n + 1) / 2;
        int actualSum = nums.Sum();
        
        int duplicate = nums.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.Key)
                            .FirstOrDefault();
        
        int missingNumber = expectedSum - (actualSum - duplicate);
        
        return new int[]{duplicate, missingNumber};
    }
}
