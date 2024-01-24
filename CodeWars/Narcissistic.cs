using System;

public class Kata
{
  public static bool Narcissistic(int value)
  {
    string valueS = value.ToString();
    int len = valueS.Length;
    int[] digits = new int[len];
    int tryValue = value;
    
    for (int i = 0; i < digits.Length; i++)
    {
      int digit = tryValue % 10;
      digits[i] = digit;
      tryValue /= 10;
    }

    double result = 0;
    foreach (var dig in digits)
    {
      result += Math.Pow(dig, len);
    }
    return result == value;
  }
}