using System;
public static class JadenCase
{
  public static string ToJadenCase(this string phrase)
  {
      var splitted = phrase.Split(" ");
      for (int i = 0; i < splitted.Length; ++i)
      {
          if (!string.IsNullOrEmpty(splitted[i]))
          {
              string word = splitted[i];
              splitted[i] = char.ToUpper(word[0]) + word.Substring(1);
          }
      }
      return string.Join(" ", splitted);
  }
}