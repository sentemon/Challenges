public static class Kata
{
    public static string Disemvowel(string str)
    {
      string result = "";
      
      for (int i = 0; i < str.Length; i++)
      {
        if (!(str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U'))
        {
          result += str[i]; 
        }
      }
      return result;
    }
}