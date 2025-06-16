using System;
using System.Text;
using System.Linq;
​
public class PlayPass
{
  public static string playPass(string s, int n)
  {
      StringBuilder builder = new();
      bool toUpperCase = true;
      for (int i = 0; i < s.Length; ++i)
      {
          char currentChar = s[i];
          if (char.IsLetter(currentChar))
          {
              char shiftedChar = ShiftLetter(currentChar, n);
              if (toUpperCase)
              {
                  builder.Append(char.ToUpper(shiftedChar));
              }
              else
              {
                  builder.Append(char.ToLower(shiftedChar));
              }
          }
          else if (char.IsDigit(currentChar))
          {
              builder.Append(9 - (int)char.GetNumericValue(currentChar));
          }
          else
          {
              builder.Append(currentChar);
          }
          toUpperCase = !toUpperCase;
      }
      var reversedArray = builder.ToString().ToCharArray();
      Array.Reverse(reversedArray);
      return new string(reversedArray);
  }
  
  private static char ShiftLetter(char c, int n)
  {
      if (char.IsUpper(c))
      {
          return (char)(((c - 'A' + n) % 26) + 'A');
      }
      else
      {
          return (char)(((c - 'a' + n) % 26) + 'a');
      }
  }
}
​