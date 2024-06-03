// Difference Of Squares
using System;

public class Kata
{
    public static int DifferenceOfSquares(int n)
    {
        int sumSquare = 0;
        int sumOfNumSquare = 0;

        for (int i = 1; i <= n; i++)
        {
            sumSquare += i;
            sumOfNumSquare += i * i;
        }

        sumSquare = sumSquare * sumSquare;

        return sumSquare - sumOfNumSquare;

    }
}