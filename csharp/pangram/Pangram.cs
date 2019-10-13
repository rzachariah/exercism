using System.Linq;
using System.Text;

public static class Pangram
{
    const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static bool IsPangram(string input)
    {
        var alphabetMap = alphabet.ToCharArray().ToDictionary(c => c, _ => 0);
        var inputAlphabetic = input
            .ToUpper()
            .Where(s => alphabet.Contains(s));
        foreach (char c in inputAlphabetic)
        {
            alphabetMap[c]++;
        }
        int charsNotPresentCount = alphabetMap.Values
            .Where(v => v == 0)
            .Count();
        return charsNotPresentCount == 0;
    }
}
