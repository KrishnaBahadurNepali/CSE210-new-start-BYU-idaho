using System;

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000; // Convert laps to km
    }

    public override double GetSpeed()
    {
        return GetDistance() / (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return LengthMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min/km";
    }
}
