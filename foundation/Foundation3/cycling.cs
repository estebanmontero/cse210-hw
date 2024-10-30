using System;

public class Cycling : Activity
{
    private double _speed; // Stores average speed

    // Constructor with date, duration, and speed
    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    // Calculate distance based on speed and time
    public override double GetDistance() => (_speed * Duration) / 60;

    // Returns the speed as stored
    public override double GetSpeed() => _speed;

    // Calculate pace from speed
    public override double GetPace() => 60 / _speed;

    // Summary specific to cycling
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Cycling: Speed {_speed} mph, Distance {GetDistance():0.0} miles, Pace: {GetPace():0.0} min/mile";
    }
}
