// 2678. Number of Senior Citizens
public class Solution 
{
    public int CountSeniors(string[] details) 
    {
        var output = 0;

        foreach (var detail in details)
        {
            if (int.Parse(detail[11..13]) > 60) 
            {
                output++;
            }
        }

        return output;
    }
}