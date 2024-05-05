using System;

public class Kata
{
  public static int GetAge(string inputString)
  {
    /*
      This works because each character is internally represented by a number. 
      The characters '0' to '9' are represented by consecutive numbers, 
      so finding the difference between the characters '0' and '2' results in the number 2.
    */
    return inputString[0] - '0';
  }
}