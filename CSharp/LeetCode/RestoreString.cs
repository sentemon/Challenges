// 1528. Shuffle String
public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] ans = new char[indices.Length];

        for (int i = 0; i < indices.Length; i++)
            ans[indices[i]] = s[i];

        return string.Join("", ans);
    }
}