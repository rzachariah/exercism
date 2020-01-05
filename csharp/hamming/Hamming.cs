using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand == null) throw new ArgumentNullException(nameof(firstStrand));
        if (secondStrand == null) throw new ArgumentNullException(nameof(secondStrand));
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException("Strands must be of equal length");

        return firstStrand.Zip(secondStrand, (f, s) => f == s ? 0 : 1)
            .Sum();
    }
}