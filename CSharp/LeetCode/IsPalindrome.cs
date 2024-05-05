public class Solution {
    public bool IsPalindrome(string s)
    {
        int leftPointer = 0;
        int rightPointer = s.Length - 1;
        s = s.ToUpper();
        
        while (leftPointer < rightPointer)
        {
            if (char.IsLetterOrDigit(s[leftPointer]))
            {
                if (char.IsLetterOrDigit(s[rightPointer]))
                {
                    if (s[leftPointer] == s[rightPointer])
                    {
                        leftPointer++;
                        rightPointer--;
                    }
                    else
                        return false;
                }
                else
                    rightPointer--;
            }
            else
                leftPointer++;
        }
        
        return true;
    }
}