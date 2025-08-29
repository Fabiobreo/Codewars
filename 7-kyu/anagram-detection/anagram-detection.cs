using System.Collections.Generic;
​
public class Kata
{
    public static bool IsAnagram(string a, string b)
    {
        if (a.Length != b.Length) return false;
        var freq = new Dictionary<char, int>();
        foreach (var ch in a.ToLower())
        {
            if (!freq.ContainsKey(ch))
            {
                freq.Add(ch, 0);
            }
            freq[ch]++;
        }
      
        foreach (var ch in b.ToLower())
        {
            if (!freq.ContainsKey(ch)) return false;
            freq[ch]--;
            if (freq[ch] == 0) freq.Remove(ch);
        }
        return freq.Count == 0;
    }
}