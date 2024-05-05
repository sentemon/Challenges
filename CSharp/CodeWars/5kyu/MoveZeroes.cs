using System.Collections.Generic;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    List<int> res = new List<int>();
                        
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i] != 0)
        res.Add(arr[i]);
    }
    
    for (int i = res.Count; i < arr.Length; i++)
      res.Add(0);
    
    return res.ToArray();
  }
}