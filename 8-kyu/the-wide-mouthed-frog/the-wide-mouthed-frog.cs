public class Kata
{
  public static string MouthSize(string animal)
  {
      return animal.ToLower() == "alligator" ? "small" : "wide";
  }
}