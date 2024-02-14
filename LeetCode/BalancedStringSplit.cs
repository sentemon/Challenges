public class Solution {
    public int BalancedStringSplit(string s) {
        int count = 0;
        int res = 0;
        
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (count == 0)
                res++;

            if (s[i] == 'L') count++;
            else count--;
        }

        return res;
    }
}