using System.Linq;
​
namespace Solution
{
  class Kata
  {
      public static int find_it(int[] seq) 
      {
          return seq.GroupBy(n => n).Single(g => g.Count() % 2 != 0).Key;
      }
  }
}