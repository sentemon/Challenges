public class Solution {
    public int[] FrequencySort(int[] nums) 
    {
        var frequencyNums = new Dictionary<int, (int, int)>();

        for (int i = 0; i < nums.Length; i++)
        {
            frequencyNums.Add(i, (nums[i], nums.Count(x => x == nums[i])));
        }

        var frequencySortNums = frequencyNums.OrderBy(x => x.Value.Item2)
                                             .ThenByDescending(x => x.Value.Item1)
                                             .ToDictionary(pair => pair.Key, pair => pair.Value.Item1);
        
        return frequencySortNums.Values.ToArray();
    }
}