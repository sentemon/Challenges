using System;

public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int sum = 0;
    
    foreach (int num in numbers)
      sum += num * num;
    
    return sum;
  }
}