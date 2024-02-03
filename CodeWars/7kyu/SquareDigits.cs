using System;
using System.Linq;

public class Kata
{
  public static int SquareDigits(int n)
    {
        int[] digits = n.ToString().Select(c => int.Parse(c.ToString())).ToArray();
        string result = "";

        foreach (var digit in digits)
        {
            result += digit * digit;
        }

        return int.Parse(result);
    }
}