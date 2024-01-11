using System;

public class Kata
{
  public static string ReverseWords(string str)
  {
    string[] words = str.Split(' '); 
    
    Array.Reverse(words);
    
    return string.Join(' ', words);
  }
}