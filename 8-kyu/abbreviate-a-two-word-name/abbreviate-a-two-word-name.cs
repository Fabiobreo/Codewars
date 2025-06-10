public class Kata
{
  public static string AbbrevName(string name)
  {
      var splitted = name.ToUpper().Split(" ");
      return $"{splitted[0][0]}.{splitted[1][0]}";
  }
}