using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    int length = name.Length;
    
    if (length == 0)
      return "no one likes this";
    else if (length == 1)
      return $"{name[0]} likes this";
    else if (length == 2)
      return $"{name[0]} and {name[1]} like this";
    else if (length == 3)
      return $"{name[0]}, {name[1]} and {name[2]} like this";
    else
      return $"{name[0]}, {name[1]} and {length - 2} others like this";
  }
}