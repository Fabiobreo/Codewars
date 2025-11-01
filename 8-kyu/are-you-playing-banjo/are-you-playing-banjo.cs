using System;
​
public class Kata
{
  public static string AreYouPlayingBanjo(string name)
  {
      return name + (name.ToLower().StartsWith("r") ? " plays" : " does not play") + " banjo";
  }
}