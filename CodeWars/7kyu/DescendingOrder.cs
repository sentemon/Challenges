using System;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    char[] arr = num.ToString().ToCharArray();
    Array.Sort(arr);
    Array.Reverse(arr);
      
    return int.Parse(arr);
  }
}
