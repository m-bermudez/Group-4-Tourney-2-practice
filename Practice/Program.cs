namespace Practice;

public class Vehicle
{
    protected string _make;
    protected string _model;
    protected int _year;

    public Vehicle(string make, string model, int year)
    {
        _make = make;
        _model = model;
        _year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle: {_make} {_model} ({_year})");
    }
}
