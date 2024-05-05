using System;

public static class Kata
{
  public static int SumTree(Node root)
  {
    if (root == null)
      return 0;
    
    int sum = root.Value;
    
    sum += SumTree(root.Left);
    sum += SumTree(root.Right);
    
    return sum;
  }
}