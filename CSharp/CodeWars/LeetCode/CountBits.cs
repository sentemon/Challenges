public class Solution {
    public int[] CountBits(int n) {
        int[] ans = new int[n + 1];

        for (int i = 0; i < ans.Length; i++)
            ans[i] = Convert.ToString(i, 2).Count(c => c == '1');

        return ans;
    }
}