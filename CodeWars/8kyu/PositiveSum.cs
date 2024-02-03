using System;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int sum = 0;
    foreach (int el in arr)
    {
      if (el > 0)
        sum += el;
    }
    
    return sum;
  }
}