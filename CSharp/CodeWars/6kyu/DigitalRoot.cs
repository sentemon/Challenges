public class Number
{
  public static int DigitalRoot(long n)
  {
      long sum = 0;
    
      while (n > 0)
      {
        sum += n % 10;
        n /= 10;
      }
    
      if(sum < 10)
        return (int)sum;
    
      return DigitalRoot(sum);  // recursion
  }
}