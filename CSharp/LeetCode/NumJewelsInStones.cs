public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        char[] jewelsArray = jewels.ToCharArray();
        int count = 0;

        foreach (var stone in stones)
            if (jewelsArray.Contains(stone))
                count++;

        return count;
    }
}