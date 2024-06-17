// 633. Sum of Square Numbers
public class Solution {
    public bool JudgeSquareSum(int c) {
        ulong sum = (ulong)c;
        ulong a = 0, b = (ulong)Math.Sqrt(sum);

        for (int i = 0; i <= Math.Sqrt(c); i++)
        {
            if (a * a + b * b == sum)
                return true;
            else if (a * a + b * b < sum)
                a++;
            else if (a * a + b * b > sum)
                b--;
        }

        return false;
    }
}