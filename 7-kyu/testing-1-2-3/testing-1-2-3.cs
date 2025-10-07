using System.Collections.Generic;
using System.Linq;
​
public class LineNumbering 
{
    public static List<string> Number(List<string> lines) 
    {
        return lines.Select((s, i) => $"{i + 1}: {s}").ToList();
    }
}