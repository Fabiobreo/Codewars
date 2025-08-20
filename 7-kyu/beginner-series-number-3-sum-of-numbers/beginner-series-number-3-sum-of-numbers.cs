  using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
       var min = Math.Min(a, b);
       var max = Math.Max(a, b);
       var sum = 0;
       for (int i = min; i <= max; ++i) sum += i;
       return sum;
     }
  }