using System.Linq;

public class Kata
{
    public static bool IsAlt(string word)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        for (int i = 0; i < word.Length - 1; i++)
        {
            if ((vowels.Contains(word[i]) && vowels.Contains(word[i + 1])) ||
                (!vowels.Contains(word[i]) && !vowels.Contains(word[i + 1])))
            {
                return false;
            }
        }
        return true;
    }
}
