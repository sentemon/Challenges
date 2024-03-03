public class Solution {
    public int Maximum69Number(int num) {
        char[] numToCharArray = num.ToString().ToCharArray();

        for (int i = 0; i < numToCharArray.Length; i++)
        {
            if (numToCharArray[i] != '9')
            {
                numToCharArray[i] = '9';
                break;
            }
        }

        return int.Parse(numToCharArray);
    }
}