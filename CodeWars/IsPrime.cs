public static class Kata
{
  public static bool IsPrime(int n)
  {
    int divisors = 1;
    
    for (int i = 1; i < n / 2 + 1; i++)
    {
      if (n % i == 0)
      {
        divisors++; 
      }
    }
    
    return divisors == 2;
  }
}