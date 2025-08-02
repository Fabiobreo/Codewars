public class Kata
{
  public static int Divisors(int n)
  {
    var result = 0;
    for (int i = 1; i <= n; ++i)
    {
        if (n % i == 0) result++;
    }
    return result;
  }
}