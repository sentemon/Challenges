public class Kata
{
  public static string FakeBin(string x)
  {
    string res = "";
    
    for (int i = 0; i < x.Length; i++)
    {
      if ((x[i] - '0') >= 5)
        res += "1";
      else
        res += "0";
    }
    
    return res;
  }
}