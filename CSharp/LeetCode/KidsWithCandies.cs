public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> result = new List<bool>();
        int maxCandies = candies.Max();
        
        for (int i = 0; i < candies.Length; i++)
            result.Add(candies[i] + extraCandies >= maxCandies);

        return result;
    }
}