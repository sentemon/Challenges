public class Solution {
    public int MinPartitions(string n) {
        int currentMax = 0;

        for (int i = 0; i < n.Length; i++)
            if (currentMax < (int)n[i] - '0')
                currentMax = (int)n[i] - '0';

        return currentMax;
    }
}