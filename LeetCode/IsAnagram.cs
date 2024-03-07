public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        return new string(sArray) == new string(tArray);
    }
}