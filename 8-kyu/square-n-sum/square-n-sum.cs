using System;
using System.Linq;
​
public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    return numbers.Sum(x => (int)Math.Pow(x, 2));
  }
}