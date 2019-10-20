using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) throw new ArgumentOutOfRangeException(nameof(number));

        var sumOfFactors = GetFactors(number)
            .Sum();
        if (sumOfFactors < number)
        {
            return Classification.Deficient;
        }
        else if (sumOfFactors > number)
        {
            return Classification.Abundant;
        }
        else
        {
            return Classification.Perfect;
        }
    }

    private static IEnumerable<int> GetFactors(int number)
    {
        return Enumerable.Range(1, number - 1)
            .Where(x => number % x == 0);
    }
}
