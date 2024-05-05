public class Solution {
    public IList<int> FindWordsContaining(string[] words, char x) {
        List<int> indices = new List<int>();

        for (int i = 0; i < words.Length; i++)
            if (words[i].Contains(x))
                indices.Add(i);

        return indices;
    }
}