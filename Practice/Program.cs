﻿namespace Practice;

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

public class SUV : Vehicle
{
    private int _seatingCapacity;
    private bool _ABS;

    public SUV(string make, string model, int year, int seatingCapacity,bool ABS)
        : base(make, model, year)
    {
        _seatingCapacity = seatingCapacity;
        _ABS = ABS;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Sedan: {_make} {_model} ({_year}) - Seating Capacity: {_seatingCapacity} , ABS is :{_ABS}");
    }
}
public class Truck : Vehicle
{
    private int _seatingCapacity;
    private bool _ABS;
    private int _towingCapacity;

    public SUV(string make, string model, int year, int seatingCapacity, bool ABS, int towingCapacity)
        : base(make, model, year)
    {
        _seatingCapacity = seatingCapacity;
        _ABS = ABS;
        _towingCapacity = towingCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Sedan: {_make} {_model} ({_year}) - Seating Capacity: {_seatingCapacity} , ABS is :{_ABS}, Towing Capacity: {_towingCapacity}");
    }
}