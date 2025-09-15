using System;
using System.Text;
​
public class Diamond
{
  public static string print(int n)
  {
      if (n <= 0 || n % 2 == 0) return null;
      var sb = new StringBuilder();
    
      for (int stars = 1; stars <= n; stars += 2)
      {
          int spaces = (n - stars) / 2;
          sb.Append(' ', spaces)
            .Append('*', stars)
            .Append('\n');
      }
    
      for (int stars = n - 2; stars >= 1; stars -= 2)
      {
          int spaces = (n - stars) / 2;
          sb.Append(' ', spaces)
            .Append('*', stars)
            .Append('\n');
      }
      return sb.ToString();
  }
}