public class Solution {
    public bool IsAcronym(IList<string> words, string s) {
        for (int i = 0; i < words.Count; i++)
        {
            if (words[i][0] != s[i] || words.Count != s.Length)
                return false;
        }
        return true;
    }
}