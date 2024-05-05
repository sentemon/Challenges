public class Solution 
{
    public int CountNegatives(int[][] grid) 
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int negatives = 0;

        for (int row = 0; row < m; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (grid[row][col] < 0)
                {
                    negatives += (m - row) * (n - col);
                    n = col;
                    break;
                }
            }
        }

        return negatives;
    }
}