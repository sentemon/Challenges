// 1678. Goal Parser Interpretation
public class Solution {
    public string Interpret(string command) {
        return command.Replace("()", "o").Replace("(al)", "al");
    }
}