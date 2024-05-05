using System;
public static class Kata
{
  public static bool IsPrime(int n)
  {
    if (n <= 1)
      return false;
    
    if (n == 2 || n == 3)
      return true;

    if (n % 2 == 0 || n % 3 == 0)
      return false;

    int sqrtN = (int)Math.Sqrt(n) + 1;
    for (int i = 5; i <= sqrtN; i += 6)
    {
      if (n % i == 0 || n % (i + 2) == 0)
      {
        return false;
      }
    }

    return true;
  }
}