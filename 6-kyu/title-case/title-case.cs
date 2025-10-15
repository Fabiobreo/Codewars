using System;
using System.Collections.Generic;
​
public class Kata
{
  public static string TitleCase(string title, string minorWords = "")
  {
    if (string.IsNullOrWhiteSpace(title)) return "";
​
    // Build a case-insensitive set of minor words
    var minors = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
    if (!string.IsNullOrWhiteSpace(minorWords))
    {
      foreach (var mw in minorWords.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        minors.Add(mw);
    }
​
    var parts = title.Split(' ', StringSplitOptions.RemoveEmptyEntries);
​
    for (int i = 0; i < parts.Length; i++)
    {
      var lower = parts[i].ToLower();
​
      // First word is always capitalized; others depend on minor word list
      if (i == 0 || !minors.Contains(lower))
      {
        parts[i] = Capitalize(lower);
      }
      else
      {
        parts[i] = lower;
      }
    }
​
    return string.Join(" ", parts);
  }
​
  private static string Capitalize(string s)
  {
    if (string.IsNullOrEmpty(s)) return s;
    return char.ToUpper(s[0]) + (s.Length > 1 ? s.Substring(1) : "");
  }
}