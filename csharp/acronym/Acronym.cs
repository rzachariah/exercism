using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var words = phrase
            .Split(" ")
            .SelectMany(w => w.Split("-"));
        var firstLetters = words
            .Where(w => w.Length > 0)
            .Select(w => w.First(c => c != '_'));
        return string.Join("", firstLetters).ToUpper();
    }
}