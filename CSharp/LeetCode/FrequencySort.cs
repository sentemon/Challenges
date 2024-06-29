// 451. Sort Characters By Frequency
public class Solution {
    public string FrequencySort(string s)
    {
        var countOfFrequency = new Dictionary<char, int>();

        foreach (var c in s)
            if (!countOfFrequency.TryAdd(c, 1))
                countOfFrequency[c]++;

        var sortedDict = countOfFrequency.OrderByDescending(entry => entry.Value);

        var ans = new StringBuilder();

        foreach (var el in sortedDict)
            ans.Append(el.Key, el.Value);

        return ans.ToString();
    }
}