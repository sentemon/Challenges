public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int x = 0;
        string[] increment = {"++X", "X++"};

        foreach (var opr in operations)
        {
            if (increment.Contains(opr))
                x++;
            else
                x--;
        }

        return x;
    }
}