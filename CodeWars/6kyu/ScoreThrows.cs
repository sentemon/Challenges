using System.Linq;

public class Darts
{
  public static int ScoreThrows(double[] radii)
  {
    if (radii == null || radii.Length == 0)
      return 0;
    
    int points = 0;
    bool bonusPoints = radii.All(el => el < 5);
    
    foreach (var el in radii)
    {
      if (el < 5)
        points += 10;
      else if (el >= 5 && el <= 10)
        points += 5;
    }
    
    if (bonusPoints)
      points += 100;
    
    return points;
    
  }
}