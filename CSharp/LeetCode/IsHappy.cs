// 202. Happy Number
public class Solution {
    public bool IsHappy(int n) {
        List<int> check = new List<int>();

        int sum = 0;

        while (sum != 1) 
        {
            sum = 0;

            while (n != 0) 
            {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            n = sum;

            if (check.Contains(sum)) break;
            else check.Add(sum);
        }

        return sum == 1;       
    }
}