using System;
using System.Linq;
​
public static class Kata
{
  public static bool IsPangram(string str)
  {
      var freq = new int[26];
      string lowerStr = str.ToLower();
      foreach (var ch in lowerStr)
      {
          if (!char.IsLetter(ch)) continue;
          freq[ch - 'a']++;
      }
      return freq.All(ch => ch > 0);
  }
}