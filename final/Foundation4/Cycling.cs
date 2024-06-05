using System;

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (LengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return 60.0 / speed;
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Speed: {speed} kph, Distance: {GetDistance()} km, Pace: {GetPace()} min/km";
    }
}
