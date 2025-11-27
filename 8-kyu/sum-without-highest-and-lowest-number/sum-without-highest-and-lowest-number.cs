using System;
using System.Linq;
​
public static class Kata
{
  public static int Sum(int[] numbers)
  {
      if (numbers == null || numbers.Length < 2) return 0;
     Array.Sort(numbers);
    int result = 0;
     for (int i = 1; i < numbers.Length - 1; ++i)
     {
        result += numbers[i];
     }
      return result;
  }
}