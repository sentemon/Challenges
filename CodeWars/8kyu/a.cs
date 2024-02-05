using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    char[] s = str.ToCharArray();
    Array.Reverse(s);
    return new string(s);
  }
}