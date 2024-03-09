public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num < 0)
            return false;
        
        for (long i = 0; i * i <= num; i++)
            if (i * i == num)
                return true;

        return false;
    }
}