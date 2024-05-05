public class Solution 
{
    public string ReverseWords(string s) 
    {
        string[] words = s.Split(" ");

        for (int i = 0; i < words.Length; i++)
            words[i] = new string(words[i].Reverse().ToArray());

        return string.Join(" ", words);
    }
}