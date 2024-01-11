using System;
public class Kata
{
  public static long FindNextSquare(long num)
  {
    long sqrt = (long)Math.Sqrt(num);
  
    if (sqrt * sqrt == num)
    {
      return (sqrt + 1) * (sqrt + 1);
    }
    return -1;   
  }
}