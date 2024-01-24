using System.Linq;

public static class Kata
{
  public static int CountSmileys(string[] smileys) 
  {
    string[] smileyFaces = new string[]
    {
      ":)", ":D",
      ";-)", ";-D",
      ":~)", ":~D",
      ":-)", ":-D",
      ";)", ";D",
      ";-)", ";-D",
      ";~)", ";~D",
      ":-)", ":-D",
      ";)", ";D",
      ";-)", ";-D",
      ";~)", ";~D"
    };

    int count = 0;
    
    foreach (var smile in smileys)
    {
      if (smileyFaces.Contains(smile))
        count++;
    }
    
    return count;
  }
}