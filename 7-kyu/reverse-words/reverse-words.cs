using System;
using System.Collections.Generic;
​
public static class Kata
{
  public static string ReverseWords(string str)
  {
      var splitted = str.Split();
      var reversed = new List<string>();
      foreach (var s in splitted)
      {
          char[] charArray = s.ToCharArray();
          Array.Reverse(charArray);
          reversed.Add(new string(charArray));
      }
      return string.Join(" ", reversed);
  } 
}