public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        for (int row = 0; row < matrix.Length; row++)
			if (Array.BinarySearch(matrix[row], target) >= 0)
				return true;

		return false;
    }
}