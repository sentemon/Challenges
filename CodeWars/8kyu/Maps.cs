public class Kata
{
  public static int[] Maps(int[] x)
  { 
    for (int i = 0; i < x.Length; i++)
    {
      x[i] = x[i] * 2;
    }
    
    return x;
  }
}