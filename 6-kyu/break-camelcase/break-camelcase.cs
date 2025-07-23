using System.Text;
​
public class Kata
{
  public static string BreakCamelCase(string str)
  {
      var builder = new StringBuilder();
      foreach (var ch in str)
      {
          if (char.IsUpper(ch))
          {
              builder.Append(" ");
          }
          builder.Append(ch);
      }
      return builder.ToString().Trim();
  }
}