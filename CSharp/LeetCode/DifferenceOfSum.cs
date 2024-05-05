public class Solution 
{
    public int DifferenceOfSum(int[] nums) 
    {
        int sumElements = nums.Sum();
        int sumDigits = 0;
        
        int i = 0;
        while (i != nums.Length)
        {
            if (nums[i].ToString().Length == 1)
            {
                sumDigits += nums[i];
                i++;
            }
            else
            {
                sumDigits += nums[i] % 10;
                nums[i] /= 10;
            }

        }

        return Math.Abs(sumElements - sumDigits);
    }
}