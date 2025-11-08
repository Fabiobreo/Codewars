using System;
​
public static class AgeDiff 
{
  public static string CalculateAge(int birth, int yearTo) 
  {
    int age = yearTo - birth;
    if (age > 1) return $"You are {age} years old.";
    if (age == 1) return "You are 1 year old.";
    if (age == 0) return "You were born this very year!";
    if (age == -1) return "You will be born in 1 year.";
    if (age < -1) return $"You will be born in {age * -1} years.";
    return "";
  }
}