using System.Linq;
​
public class TwoToOne 
{
  public static string Longest (string s1, string s2) => new string(s1.Concat(s2).Distinct().OrderBy(c => c).ToArray());
}