using System;

public class Running : Activity
{
    private double _distance; // Stores the distance run

    // Constructor with date, duration, and distance
    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    // Override for distance
    public override double GetDistance() => _distance;

    // Calculates speed in miles per hour (or kilometers per hour if modified)
    public override double GetSpeed() => (_distance / Duration) * 60;

    // Calculates pace in minutes per mile (or per km)
    public override double GetPace() => Duration / _distance;

    // Summary specific to running
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Running: Distance {_distance} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min/mile";
    }
}
