﻿using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number < 1) throw new ArgumentException(nameof(number));
        
        var steps = 0;
        while (number != 1)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = 3 * number + 1;
            }
            steps++;
        }
        return steps;
    }
}