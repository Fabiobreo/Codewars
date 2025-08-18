public class Kata
{
  public static int SaleHotDogs(int n)
  {
    return n < 5 ? n * 100 : n < 10 ? n * 95 : n * 90;
  }
}