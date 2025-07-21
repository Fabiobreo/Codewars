using System.Collections.Generic;
using System;
​
public class Kata
{
  public static Dictionary<char, int> Count(string str)
  {
    var freq = new Dictionary<char, int>();
    foreach (var ch in str)
    {
        if (!freq.ContainsKey(ch))
        {
            freq.Add(ch, 0);
        }
        freq[ch]++;
    }
    return freq;
  }
}