class Kata
{
    public static int[] RowWeights(int[] a)
    {
        int first = 0;
        int second = 0;
        for (int i = 0; i < a.Length; ++i)
        {
            if (i % 2 == 0)
            {
                first += a[i];
            }
            else
            {
                second += a[i];
            }
        }
        return new int[] { first, second };
    }
}