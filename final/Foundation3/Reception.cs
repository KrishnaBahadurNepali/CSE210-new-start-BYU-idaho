using System;

public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public string RsvpEmail => rsvpEmail;

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}