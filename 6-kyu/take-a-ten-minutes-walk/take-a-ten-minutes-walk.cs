public class Kata
{
  public static bool IsValidWalk(string[] walk)
  {
      if (walk.Length != 10) return false;
    
      int northSouth = 0;
      int eastWest = 0;
      foreach (var dir in walk)
      {
          if (dir == "n")
          {
              northSouth++;
          }
          else if (dir == "s")
          {
              northSouth--;
          }
          else if (dir == "e")
          {
              eastWest++;
          }
          else if (dir == "w")
          {
              eastWest--;
          }
      }
      return northSouth == 0 && eastWest == 0;
  }
}