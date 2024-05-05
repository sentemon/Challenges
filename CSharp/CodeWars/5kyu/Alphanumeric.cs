public class Kata
{
  public static bool Alphanumeric(string str)
  {
    string alphanumeric = "abcdefghijklmnopqrstuvwxyz0123456789";
    if (str != null && str != "")
    {
      foreach (char chr in str.ToLower())
      {
        if (!(alphanumeric.Contains(chr)))
        {
          return false;
        }
      }

      return true;
    }
    
    return false;
  }
}