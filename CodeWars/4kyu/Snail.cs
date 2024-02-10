using System.Collections.Generic;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        List<int> result = new List<int>();

        if (array != null && array.Length > 0 && array[0].Length == array.Length)
        {
            int size = array.Length;

            for (int n = 0; n < (size + 1) / 2; n++)
            {
                for (int x = n; x < size - n; x++)
                    result.Add(array[n][x]);

                for (int y = 1 + n; y < size - n; y++)
                    result.Add(array[y][size - 1 - n]);

                for (int x = 2 + n; x < size - n + 1; x++)
                    result.Add(array[size - 1 - n][size - x]);

                for (int y = 2 + n; y < size - n; y++)
                    result.Add(array[size - y][n]);
            }
        }

        return result.ToArray();
    }
}