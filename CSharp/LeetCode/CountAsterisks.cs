// 2315. Count Asterisks
public class Solution {
    public int CountAsterisks(string s) {
        int count = 0;
        string[] words = s.Split("|");

        for (int i = 0; i < words.Length; i++)
            if (i % 2 == 0)
                count += words[i].Count(x => x == '*');

        return count;

    }
}