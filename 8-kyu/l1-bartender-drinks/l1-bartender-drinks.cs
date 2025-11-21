using System.Collections.Generic;
public class Kata
{
  private static Dictionary<string, string> dict = new()
  {
      {"jabroni", "Patron Tequila"},
      {"school counselor", "Anything with Alcohol"},
      {"programmer", "Hipster Craft Beer"},
      {"bike gang member", "Moonshine"},
      {"politician", "Your tax dollars"},
      {"rapper", "Cristal"}
  };
  
  public static string GetDrinkByProfession(string p)
  {
      return dict.ContainsKey(p.ToLower()) ? dict[p.ToLower()] : "Beer";
  }
}