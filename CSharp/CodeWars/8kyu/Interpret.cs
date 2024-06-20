// 8kyu interpreters: HQ9+
public class HQ9
{
    public static string Interpret(string code)
    {
        if (code == "H")
            return "Hello World!";
        
        else if (code == "Q")
            return code;
        
        else if (code == "9")
        {
            string lyrics = "";

            for (int i = 99; i > 1; i--)
            {
                lyrics += $"{i} bottles of beer on the wall, {i} bottles of beer.\n" +
                          $"Take one down and pass it around, {i - 1} bottle{(i - 1 == 1 ? "" : "s")} of beer on the wall.\n";
            }

            lyrics += "1 bottle of beer on the wall, 1 bottle of beer.\n" +
                      "Take one down and pass it around, no more bottles of beer on the wall.\n" +
                      "No more bottles of beer on the wall, no more bottles of beer.\n" +
                      "Go to the store and buy some more, 99 bottles of beer on the wall.";

            return lyrics;
        }
        
        return null;
    }
}