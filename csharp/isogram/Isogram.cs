using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var alphabeticPortion = word
            .ToUpper()
            .ToCharArray()
            .Where(c => Char.IsLetter(c));

        return alphabeticPortion.Count() == alphabeticPortion.Distinct().Count();
    }
}
