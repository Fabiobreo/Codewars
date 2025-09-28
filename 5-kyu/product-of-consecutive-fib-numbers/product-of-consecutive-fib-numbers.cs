public class ProdFib
{
    public static ulong[] productFib(ulong prod)
    {
        ulong a = 0UL;
        ulong b = 1UL;
​
        while (true)
        {
            if (a > 0 && a > prod / b)
                return new ulong[] { a, b, 0UL };
​
            ulong product = a * b;
            if (product == prod)
                return new ulong[] { a, b, 1UL };
            if (product > prod)
                return new ulong[] { a, b, 0UL };
​
            ulong next = a + b;
            a = b;
            b = next;
        }
    }
}