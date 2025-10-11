using System;
​
public class Kata
{   
  public static string NameShuffler(string str)
  {
    var split = str.Split(" ");
    return split[1] + " " + split[0];
  }
}