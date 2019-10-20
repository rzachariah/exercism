using System;
using System.Linq;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        var rnaChars = nucleotide
            .ToUpper()
            .ToCharArray()
            .Where(c => "ACTG".Contains(c))
            .Select(c => 
            {
                switch(c) {
                    case 'A':
                        return 'U';
                    case 'C':
                        return 'G';
                    case 'T':
                        return 'A';
                    case 'G':
                        return 'C';
                }
                throw new ApplicationException("2+2==5");
            })
            .ToArray();
        return new String(rnaChars);
    }
}