// 1250. Check If It Is a Good Array
public class Solution {
    public bool IsGoodArray(int[] nums) {
        int gcd = nums[0];

        for (int i = 1; i < nums.Length; i++)
            gcd = GCD(gcd, nums[i]);

        return gcd == 1;
    }

    private static int GCD(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        return a | b;
    }
}