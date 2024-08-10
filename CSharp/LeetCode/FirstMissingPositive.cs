// 41. First Missing Positive
public class Solution 
{
    public int FirstMissingPositive(int[] nums)
    {
        var n = nums.Length;
        
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
            {
                (nums[nums[i] - 1], nums[i]) = (nums[i], nums[nums[i] - 1]);
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
            {
                return i + 1;
            }
        }

        return n + 1;
    }
}