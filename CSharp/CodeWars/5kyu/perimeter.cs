using System;
using System.Numerics;

public class SumFct
{
  public static BigInteger perimeter(BigInteger n) 
  {
    BigInteger fPrime = 0;
    BigInteger f = 1;

    BigInteger sum = 0;

    for (BigInteger i = 2; i <= n + 2; i++)
    {
      BigInteger next = f + fPrime;
      fPrime = f;
      f = next;

      sum += fPrime;
    }

    return sum * 4;
  }
}