public class Kata
{
    public static string UpdateLight(string current)
    {
        switch (current)
        {
            case "green": return "yellow";
            case "yellow": return "red";
            case "red": return "green";
        }
        return "";
    }
}