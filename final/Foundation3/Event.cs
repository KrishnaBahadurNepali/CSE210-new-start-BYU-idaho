using System;

public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string Title => title;
    public string Description => description;
    public DateTime Date => date;
    public TimeSpan Time => time;
    public Address Address => address;

    public virtual string StandardDetails()
    {
        return $"Event Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString(@"hh\:mm")}\nAddress: {address.GetFullAddress()}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDescription()
    {
        return $"Type: {GetType().Name}\nEvent Title: {title}\nDate: {date.ToShortDateString()}";
    }
}
