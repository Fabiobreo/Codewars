using System;
using System.Linq;
​
public static class Kata
{
  public static string Array(string s)
  {
      var split = s.Split(",").ToList();
      if (split.Count < 3) return null;
      split.RemoveAt(0);
      split.RemoveAt(split.Count - 1);
      return string.Join(" ", split);
  }
}