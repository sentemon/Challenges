using System;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    int[] nums = Array.ConvertAll(numbers.Split(" "), int.Parse);

    return $"{nums.Max()} {nums.Min()}";
  }
}