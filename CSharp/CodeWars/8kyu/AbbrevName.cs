// Abbreviate a Two Word Name
public class Kata
{
  public static string AbbrevName(string name)
  {
    var res = name.Split(" ");
    return $"{res[0][0]}.{res[1][0]}".ToUpper();
  }
}