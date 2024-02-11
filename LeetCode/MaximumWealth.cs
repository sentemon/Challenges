using System.Linq;

public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
    {
        int[] wealth = new int[accounts.Length];

        for (int i = 0; i < accounts.Length; i++) 
        {
            for (int j = 0; j < accounts[i].Length; j++)
                wealth[i] += accounts[i][j];
        }

        return wealth.Max();
    }
}