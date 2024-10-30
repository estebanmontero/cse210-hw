using System;

public class Swimming : Activity
{
    private int _laps; // Number of laps swum

    // Constructor with date, duration, and laps
    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    // Calculate distance in miles (each lap is 50 meters)
    public override double GetDistance() => (_laps * 50) / 1000.0 * 0.62;

    // Calculate speed in miles per hour
    public override double GetSpeed() => (GetDistance() / Duration) * 60;

    // Calculate pace in minutes per mile
    public override double GetPace() => Duration / GetDistance();

    // Summary specific to swimming
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Swimming: Laps {_laps}, Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min/mile";
    }
}
