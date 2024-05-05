using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    List<int> numbers = new List<int>();
    
    foreach (var el in a)
    {
      if (!b.Contains(el))
        numbers.Add(el);
    }
    
    return numbers.ToArray();
  }
}