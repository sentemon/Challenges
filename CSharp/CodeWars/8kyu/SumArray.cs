using System.Linq;
public class Kata
{
  public static double SumArray(double[] array)
  {
    if (array != null)
      return array.Sum();
    else
      return 0;
  }
}