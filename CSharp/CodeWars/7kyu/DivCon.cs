// Divide and Conquer
using System;

public class Kata
{
    public static int DivCon(Object[] objArray)
    {
        int sumOfInt = 0;
        int sumOfStr = 0;
        
        foreach (var el in objArray)
        {
            if (el is Int32)
                sumOfInt += (int)el;
            else if (el is String)
                sumOfStr += int.Parse((string)el);
        }

        return sumOfInt - sumOfStr;
    }
}