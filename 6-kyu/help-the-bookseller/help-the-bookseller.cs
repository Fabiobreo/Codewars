using System;
using System.Linq;
using System.Collections.Generic;
​
public class StockList
{
    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
    {
        if (lstOfArt == null || lstOfArt.Length == 0 || lstOf1stLetter == null || lstOf1stLetter.Length == 0)
        {
            return "";
        }
​
        var resultList = new List<string>();
​
        foreach (var letter in lstOf1stLetter)
        {
            int sum = 0;
​
            foreach (var art in lstOfArt)
            {
                if (art.StartsWith(letter))
                {
                    string[] parts = art.Split(' ');
                    if (parts.Length >= 2)
                    {
                        sum += int.Parse(parts[1]);
                    }
                }
            }
​
            resultList.Add($"({letter} : {sum})");
        }
​
        return string.Join(" - ", resultList);
    }
}