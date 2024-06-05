using System;

public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public string WeatherForecast => weatherForecast;

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}
