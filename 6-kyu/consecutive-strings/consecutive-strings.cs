using System.Text;
​
public class LongestConsecutives
{
    public static string LongestConsec(string[] strarr, int k)
    {
        if (strarr == null || k <= 0) return "";
        int n = strarr.Length;
        if (n == 0 || k > n) return "";
​
        int windowLen = 0;
        for (int i = 0; i < k; i++)
            windowLen += strarr[i].Length;
​
        int bestLen = windowLen;
        int bestStart = 0;
​
        for (int i = 1; i <= n - k; i++)
        {
            windowLen = windowLen - strarr[i - 1].Length + strarr[i + k - 1].Length;
            if (windowLen > bestLen)
            {
                bestLen = windowLen;
                bestStart = i;
            }
        }
​
        var sb = new StringBuilder(bestLen);
        for (int i = bestStart; i < bestStart + k; i++)
            sb.Append(strarr[i]);
​
        return sb.ToString();
    }
}