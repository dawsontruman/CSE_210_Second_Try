using System;

public class OutdoorGathering: Event
{
    private string _weather;
    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
    : base(title, description, date, time, address)
    {
        _typeName = "Outdoor Gathering";
        _weather = weather;
    }
    public override string FullDetails()
    {
        return base.FullDetails() + $"\n{_weather}";
    }
}