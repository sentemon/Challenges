public class Solution {
    public bool IsPowerOfTwo(int n) {
        return Convert.ToString(n, 2).Count(x => x == '1') == 1 && n > -1;
    }
}