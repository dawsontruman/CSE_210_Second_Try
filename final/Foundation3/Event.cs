using System;

public class Event
{
    protected string _typeName;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string title, string description, string date, string time, Address address)
    {
        _typeName = "Event";
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string StandardDetails()
    {
        return $"{_typeName}: {_title}\n{_description}\n{_date}, {_time}\n{_address.AddressString()}";
    }
    public string ShortDescription()
    {
        return $"{_typeName}, {_title}, {_date}";
    }
    // While this is not an assignment that requires polymorphism, a virtual FullDetails() method,
    // with overrides in derived classes, makes sense.
    public virtual string FullDetails()
    {
        return StandardDetails();
    }
}