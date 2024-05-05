public class Solution {
    public bool IsSameAfterReversals(int num) {
        return (num == 0) || (num % 10 != 0);
    }
}