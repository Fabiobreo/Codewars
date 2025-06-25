using System;
​
public static class Kata
{
  public static int sumTwoSmallestNumbers(int[] numbers)
  {
    int min = Math.Min(numbers[0], numbers[1]);
    int max = Math.Max(numbers[0], numbers[1]);
    for (int i = 2; i < numbers.Length; ++i)
    {
        if (numbers[i] < max)
        {
            max = Math.Max(min, numbers[i]);
            min = Math.Min(min, numbers[i]);
        }
    }
    return min + max;
  }
}