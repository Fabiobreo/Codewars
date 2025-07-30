using System.Text;
​
public class Kata
{
  public static string Rot13(string message)
  {
      StringBuilder builder = new StringBuilder();
      foreach (var ch in message)
      {
          if (char.IsLetter(ch))
          {
              var baseCh = char.IsUpper(ch) ? 'A' : 'a';
              var newCh = (char)((((ch - baseCh) + 13) % 26) + baseCh);
              builder.Append(newCh);
          }
          else
          {
              builder.Append(ch);
          }
      }
      return builder.ToString();
  }
}