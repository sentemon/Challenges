// Is it a letter?
public class Kata
{
    public static bool IsItLetter(char c)
    {
        if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122))
            return true;
      
        return false;
    }  
}