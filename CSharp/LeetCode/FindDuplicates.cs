// 442. Find All Duplicates in an Array
public class Solution {
    public IList<int> FindDuplicates(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        List<int> duplicates = new List<int>();

        foreach (var num in nums)
        {
            if (!seen.Add(num))
                duplicates.Add(num);
        }

        return duplicates;
    }
}