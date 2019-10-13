using System.Linq;
using System.Text;

public static class Pangram
{
    const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static bool IsPangram(string input)
    {
        return 26 == input.Where(c => char.IsLetter(c)).Select(c => char.ToUpper(c)).Distinct().Count();
    }
}
