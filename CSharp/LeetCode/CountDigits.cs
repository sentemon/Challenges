// 2520. Count the Digits That Divide a Number
public class Solution {
    public int CountDigits(int num) {
        int count = 0;

        foreach (var i in num.ToString())
            if (num % (i - '0') == 0)
                count++;

        return count;
    }
}