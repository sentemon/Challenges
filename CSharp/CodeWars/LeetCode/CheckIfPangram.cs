public class Solution {
    public bool CheckIfPangram(string sentence) {
        string letters = new string(sentence.Distinct().ToArray());

        return letters.Length == 26;
    }   
}