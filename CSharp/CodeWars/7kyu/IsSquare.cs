using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    return (int)Math.Sqrt(n) * (int)Math.Sqrt(n) == n;
  }
}