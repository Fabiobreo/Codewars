public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        if (a + b <= c || b + c <= a || a + c <= b) return false;
        return true;
    }
}