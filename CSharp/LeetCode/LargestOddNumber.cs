// 1903. Largest Odd Number in String
public class Solution {
    public string LargestOddNumber(string num)
    {
        for (int i = num.Length - 1; i >= 0; i--)
            if ((num[i] - '0') % 2 != 0)
                return num.Substring(0, i + 1);

        return "";
    }
}