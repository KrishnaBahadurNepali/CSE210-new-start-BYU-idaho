using System;

public class Activity
{
    private DateTime date;
    private int lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public DateTime Date => date;
    public int LengthMinutes => lengthMinutes;

    public virtual double GetDistance()
    {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation, overridden in derived classes
    }

    public virtual string GetSummary()
    {
        return $"{date.ToShortDateString()} - {GetType().Name} ({lengthMinutes} min)";
    }
}