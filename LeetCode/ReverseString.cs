public class Solution {
    public void ReverseString(char[] s) {
        for(int i = 0, j = s.Length-1; i < s.Length/2 ; i++, j--)
            (s[i], s[j]) = (s[j], s[i]);
    }
}