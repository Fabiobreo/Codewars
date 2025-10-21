class Kata
{
    public static string Solve(string s)
    {
      int low = 0;
      int high = 0;
      foreach (var ch in s)
      {
          if (ch >= 'a' && ch <= 'z') low++;
          else high++;
      }
      return low >= high ? s.ToLower() : s.ToUpper();
    }
}