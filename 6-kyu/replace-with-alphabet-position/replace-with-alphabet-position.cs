using System.Collections.Generic;
​
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
      var lower = text.ToLower();
      List<int> chars = new();
      foreach (var ch in lower)
      {
          var transformed = ch - 'a' + 1;
          if (transformed <= 0 || transformed > 26) continue;
          chars.Add(transformed);
      }
      return string.Join(" ", chars);
  }
}