using System;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers)
  {
    if (numbers != null && numbers.Length > 1)
    {
      return numbers.Sum() - numbers.Max() - numbers.Min();
    }

    return 0;
  }
}