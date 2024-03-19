public class Solution {
    public int[] SeparateDigits(int[] nums) {
        string res = "";

        foreach (var el in nums)
            res += el.ToString();

        char[] charArray = res.ToCharArray();
        int[] result = new int[charArray.Length];

        for (int i = 0; i < charArray.Length; i++)
            result[i] = int.Parse(charArray[i].ToString());

        return result;
    }
}