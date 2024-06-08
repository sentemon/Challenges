// 3146. Permutation Difference between Two Strings
public class Solution {
    public int FindPermutationDifference(string s, string t)
    {
        int sum = 0;
        
        for (int i = 0; i < s.Length; i++)
            sum += Math.Abs(s.IndexOf(s[i]) - s.IndexOf(t[i]));

        return sum;
    }
}