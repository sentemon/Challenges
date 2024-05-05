public class Solution {
    public int[] SumZero(int n)
    {
        int[] arr = new int[n];

        // If n is odd, start from index 1, otherwise start from index 0
        for (int i = n % 2 != 0 ? 1 : 0; i < arr.Length - 1; i += 2)
        {
            arr[i] = i + 1;
            arr[i + 1] = -(i + 1);
        }

        return arr;
    }
}