// Get the Middle Character
public class Kata
{
  public static string GetMiddle(string s)
  { 
    int len = s.Length;
    
    if (len % 2 == 0)
      return s[(len / 2 - 1)..(len / 2 + 1)];
    else
      return s[(len / 2)].ToString();

    // return len % 2 == 0 ? s[(len / 2 - 1)..(len / 2 + 1)] : s[(len / 2)].ToString();
  }
}