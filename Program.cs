using System;

class Airplane
{
    private string airplaneName;
    private string manufacturer;
    private int yearOfManufacture;
    private string airplaneType;

    public Airplane(string airplaneName, string manufacturer, int yearOfManufacture, string airplaneType)
    {
        this.airplaneName = airplaneName;
        this.manufacturer = manufacturer;
        this.yearOfManufacture = yearOfManufacture;
        this.airplaneType = airplaneType;
    }

    public void SetAirplaneName(string airplaneName)
    {
        this.airplaneName = airplaneName;
    }

    public string GetAirplaneName()
    {
        return airplaneName;
    }

    public void SetManufacturer(string manufacturer)
    {
        this.manufacturer = manufacturer;
    }

    public string GetManufacturer()
    {
        return manufacturer;
    }

    public void SetYearOfManufacture(int yearOfManufacture)
    {
        this.yearOfManufacture = yearOfManufacture;
    }

    public int GetYearOfManufacture()
    {
        return yearOfManufacture;
    }

    public void SetAirplaneType(string airplaneType)
    {
        this.airplaneType = airplaneType;
    }

    public string GetAirplaneType()
    {
        return airplaneType;
    }

    public void DisplayAirplaneInfo()
    {
        Console.WriteLine($"Airplane Name: {airplaneName}");
        Console.WriteLine($"Manufacturer: {manufacturer}");
        Console.WriteLine($"Year of Manufacture: {yearOfManufacture}");
        Console.WriteLine($"Airplane Type: {airplaneType}");
    }
}

class Program
{
    static void Main()
    {
        Airplane airplane = new Airplane("Boeing 747", "Boeing", 1968, "Passenger");
        airplane.DisplayAirplaneInfo();
    }
}
