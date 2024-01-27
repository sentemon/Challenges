using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] DivisibleBy(int[] numbers, int divisor)
  {
    List<int> myList = new List<int>(); 
    
    foreach (var num in numbers)
    {
      if (num % divisor == 0)
        myList.Add(num);
    }
    
    return myList.ToArray();
  }
}