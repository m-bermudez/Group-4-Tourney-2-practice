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

public class Sedan : Vehicle
{
    private int _seatingCapacity;

    public Sedan(string make, string model, int year, int seatingCapacity)
        : base(make, model, year)
    {
        _seatingCapacity = seatingCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Sedan: {_make} {_model} ({_year}) - Seating Capacity: {_seatingCapacity}");
    }
}