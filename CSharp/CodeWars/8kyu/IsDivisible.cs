public class DivisibleNb 
{
	public static bool IsDivisible(int n, int x, int y) 
  {
		return n % x == 0 && n % y == 0;
  }
}