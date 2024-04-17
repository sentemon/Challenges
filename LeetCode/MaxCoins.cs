public class Solution {
    public int MaxCoins(int[] piles) {
        Array.Sort(piles);
        int ans = 0;

        for (int i = piles.Length / 3; i < piles.Length; i += 2) 
            ans += piles[i];
        
        return ans;
    }
}