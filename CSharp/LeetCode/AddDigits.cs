// 258. Add Digits
public class Solution 
{
    public int AddDigits(int num) 
    {
        if (num == 0) 
            return 0;
        else if (num % 9 == 0) 
            return 9;
            
        return num % 9;
    }
}