public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] squares = new int[nums.Length];

        for (int i = 0; i < squares.Length; i++)
            squares[i] = nums[i] * nums[i];
        Array.Sort(squares);
        
        return squares;
    }
}