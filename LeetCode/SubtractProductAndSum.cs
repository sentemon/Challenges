public class Solution {
    public int SubtractProductAndSum(int n) 
    {
        int[] digits = n.ToString().Select(c => int.Parse(c.ToString())).ToArray();
        int sumOfDigits = 0;
        int productOfDigits = 1;

        foreach (var digit in digits)
            sumOfDigits += digit;
        
        foreach (var digit in digits)
            productOfDigits *= digit;

        return productOfDigits - sumOfDigits;
    }
}