public class Kata
{
    public static int RoundToNext5(int n)
    {
      int r = ((n % 5) + 5) % 5;
      return n + ((5 - r) % 5);
    }
}