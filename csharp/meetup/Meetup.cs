using System;
using System.Linq;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private readonly int _month;
    private readonly int _year;

    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var monthStart = new DateTime(_year, _month, 1);
        var monthEnd = monthStart.AddMonths(1).AddDays(-1);

        switch (schedule)
        {
            case Schedule.Last:
                return Enumerable.Range(0, 7)
                .Select(offset => monthEnd.AddDays(-offset))
                .First(candidate => candidate.DayOfWeek == dayOfWeek);
            case Schedule.Teenth:
                return Enumerable.Range(12, 7)
                .Select(offset => monthStart.AddDays(offset))
                .First(candidate => candidate.DayOfWeek == dayOfWeek);
            default:
                return Enumerable.Range(0, 31)
                .Select(offset => monthStart.AddDays(offset))
                .First(candidate =>
                {
                    if (candidate.Month != _month) return false;

                    if (candidate.DayOfWeek != dayOfWeek) return false;

                    var week = ((candidate.Day - 1) / 7);
                    switch (schedule)
                    {
                        case Schedule.First:
                            return week == 0;
                        case Schedule.Second:
                            return week == 1;
                        case Schedule.Third:
                            return week == 2;
                        case Schedule.Fourth:
                            return week == 3;
                    }
                    return false;
                });
        }
    }
}