public class Solution {
    public int MostWordsFound(string[] sentences) {
        int[] countWords = new int[sentences.Length];

        for (int i = 0; i < sentences.Length; i++)
            countWords[i] = sentences[i].Split(" ").Length;

        return countWords.Max();
    }
}
