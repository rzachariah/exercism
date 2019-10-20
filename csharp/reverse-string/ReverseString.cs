using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        return input
            .ToCharArray()
            .Aggregate("", (acc, x) => x + acc);
    }
}