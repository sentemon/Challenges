public class Solution {
    public int[] SortArray(int[] nums) 
    {
        if (nums.Length <= 1)
            return nums;

        int middle = nums.Length / 2;
        int[] left = SortArray(nums[..middle]);
        int[] right = SortArray(nums[middle..]);

        return MergeTwoArray(left, right);
    }

    private int[] MergeTwoArray(int[] a, int[] b)
    {
        var result = new List<int>();
        int i = 0;
        int j = 0;

        while (i < a.Length && j < b.Length)
        {
            if (a[i] < b[j])
                result.Add(a[i++]);
            else
                result.Add(b[j++]);
        }

        if (i < a.Length)
            result.AddRange(a[i..]);
        if (j < b.Length)
            result.AddRange(b[j..]);

        return result.ToArray();
    }
}
