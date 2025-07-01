using System.Text;
​
public class DnaStrand 
{
    public static string MakeComplement(string dna)
    {
        var builder = new StringBuilder(dna.Length);
        foreach (var ch in dna)
        {
            if (ch == 'A')
            {
                builder.Append('T');
            }
            else if (ch == 'T')
            {
                builder.Append('A');
            }
            else if (ch == 'G')
            {
                builder.Append('C');
            }
            else if (ch == 'C')
            {
                builder.Append('G');
            }
        }
        return builder.ToString();
    }
}