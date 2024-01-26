using System;

public static class Kata
{
	public static double Converter(int mpg)
	{
		double imperialGallon = 4.54609188;
    double mile = 1.609344;
    
    double result = (mpg * mile) / imperialGallon;
    
    return Math.Round(result, 2);
	}
}