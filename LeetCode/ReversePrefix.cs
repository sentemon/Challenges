public class Solution {
    public string ReversePrefix(string word, char ch) {
        if (!word.Contains(ch))
            return word;
        
        string reversedStr = "";
        int indexOfChar = word.IndexOf(ch);

        for (int i = indexOfChar; i >= 0 ; i--)
            reversedStr += word[i];

        return reversedStr + word[(indexOfChar + 1)..]; // concatenate the reversed string and what's left
    }
}