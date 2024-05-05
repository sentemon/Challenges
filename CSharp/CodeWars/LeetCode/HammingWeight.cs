public class Solution {
    public int HammingWeight(int n) {
        string bits = Convert.ToString(n, 2);

        return bits.Count(x => x == '1');
    }
}