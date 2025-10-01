using System;
using System.Linq;
​
public class Kata
{
  public static int SumDigits(int number)
  {
      return ((int)Math.Abs(number)).ToString().Sum(c => c - '0');
  }
}