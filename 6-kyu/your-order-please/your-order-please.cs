using System;
​
public static class Kata
{
  public static string Order(string words)
  {
      if (string.IsNullOrWhiteSpace(words)) return "";
      Console.WriteLine(words);
      var splitted = words.Split();
      string[] ordered = new string[splitted.Length];
      foreach (var str in splitted)
      {
          foreach (var ch in str)
          {
              if (!char.IsLetter(ch))
              {
                  ordered[ch - '1'] = str;
                  break;
              }
          }
      }
      return string.Join(" ", ordered);
  }
}