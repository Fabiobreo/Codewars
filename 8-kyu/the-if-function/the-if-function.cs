using System;
​
public class Kata
{
  public static void If(bool condition, Action func1, Action func2)
  {
    if (condition)
    {
        func1();
    }
    else
    {
      func2();
    }
  }
}