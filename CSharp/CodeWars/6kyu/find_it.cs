// Find the odd int
namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
    {
      int result = 0;
      
      foreach (var num in seq)
        result ^= num;
      
      return result;
    }
       
  }
}