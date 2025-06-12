using System;
using System.Collections.Generic;
​
public class Kata
{
  public static int DuplicateCount(string str)
  {
      var lowerStr = str.ToLower();
      var freq = new Dictionary<char, int>();
      foreach (var ch in lowerStr)
      {
          if (!freq.ContainsKey(ch))
          {
              freq.Add(ch, 0);
          }
          freq[ch]++;
      }
      int repeated = 0;
      foreach (var key in freq.Keys)
      {
          if (freq[key] > 1)
          {
              repeated++;
          }
      }
      return repeated;
  }
}