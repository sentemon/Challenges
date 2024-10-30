// 806. Number of Lines To Write String
public class Solution 
{
    public int[] NumberOfLines(int[] widths, string s) 
    {
        int linesCount = 1;
        int sumOfRow = 0;

        foreach (var width in s.Select(c => widths[c - 'a']))
        {
            if (sumOfRow + width > 100)
            {
                linesCount++;
                sumOfRow = width;
            }
            else
            {
                sumOfRow += width;
            }
        }

        return [linesCount, sumOfRow];
    }
}