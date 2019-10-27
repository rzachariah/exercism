using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var digits = phoneNumber
            .ToCharArray()
            .Where(c => Char.IsDigit(c))
            .Select(c => int.Parse(c.ToString()))
            .SkipWhile(c => c == 1)
            .ToArray();
        if (digits.Length != 10 || digits[0] < 2 || digits[3] < 2) throw new ArgumentException();

        return digits.Aggregate("", (cur, next) => cur + next);
    }
}