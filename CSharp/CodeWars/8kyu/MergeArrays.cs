// Merge two sorted arrays into one
using System;
using System.Linq;
public class Kata
{
  public static int[] MergeArrays(int[] arr1, int[] arr2)
  {
    int[] mergedArray = arr1.Concat(arr2).Distinct().OrderBy(x => x).ToArray();
    
    return mergedArray;
  }
}