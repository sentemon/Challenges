using System.Linq;

public class Kata
{
  public static int FindShort(string s)
  {
    string[] words = s.Split();
    int[] lenOfWords = new int[words.Length];
    
    for (int i = 0; i < lenOfWords.Length; i++)
      lenOfWords[i] = words[i].Length;
    
    return lenOfWords.Min();
  }
}