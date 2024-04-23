public class Solution {
    public string TruncateSentence(string s, int k) {
        string[] words = s.Split();
        string ans = "";

        for (int i = 0; i < k; i++)
            ans += words[i] + " ";

        return ans[..^1];
    }
}