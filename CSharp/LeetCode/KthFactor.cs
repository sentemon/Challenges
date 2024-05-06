// 1492. The kth Factor of n
public class Solution {
    public int KthFactor(int n, int k)
    {
        if (k == 1) 
            return 1;

        int count = 1;
        
        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
                
                if (count == k) 
                    return i;
            }
        }

        return -1;
    }
}