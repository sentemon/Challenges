using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
    int sum = a + b;
    
    return Convert.ToString(sum, 2);
  }
}