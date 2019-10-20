using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        return moment.Add(TimeSpan.FromSeconds(Math.Pow(10, 9)));
    }
}