using System.Linq;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        return Colors().ToList().IndexOf(color?.ToString());
    }

    public static string[] Colors() => new string[]
        {
            "black",
            "brown",
            "red",
            "orange",
            "yellow",
            "green",
            "blue",
            "violet",
            "grey",
            "white"
        };
}