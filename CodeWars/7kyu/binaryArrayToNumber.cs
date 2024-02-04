using System;
namespace Solution
{
  class Kata
  {
    public static int binaryArrayToNumber(int[] BinaryArray)
    {
      double result = 0;
      Array.Reverse(BinaryArray);
        
      for (int i = 0; i < BinaryArray.Length; i++)
      {
        if (BinaryArray[i] == 1)
          result += Math.Pow(2, i);
      }

      return (int)result;
    }
  }
}