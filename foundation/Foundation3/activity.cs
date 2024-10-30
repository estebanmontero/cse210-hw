using System;

public class Activity
{
    // Stores the date of the activity
    public DateTime Date { get; private set; }
    // Stores the duration of the activity in minutes
    public int Duration { get; private set; }

    // Constructor to initialize the date and duration
    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    // Virtual methods to be overridden in derived classes
    public virtual double GetDistance() => 0;
    public virtual double GetSpeed() => 0;
    public virtual double GetPace() => 0;

    // Summary of activity details
    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} Activity ({Duration} min)";
    }
}
