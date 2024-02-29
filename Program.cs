using System;

class City
{
    private string cityName;
    private string countryName;
    private int population;
    private int areaCode;
    private string[] districts;

    public City(string cityName, string countryName, int population, int areaCode, string[] districts)
    {
        this.cityName = cityName;
        this.countryName = countryName;
        this.population = population;
        this.areaCode = areaCode;
        this.districts = districts;
    }

    public void SetCityName(string name)
    {
        cityName = name;
    }

    public string GetCityName()
    {
        return cityName;
    }

    public void SetCountryName(string name)
    {
        countryName = name;
    }

    public string GetCountryName()
    {
        return countryName;
    }

    public void SetPopulation(int population)
    {
        this.population = population;
    }

    public int GetPopulation()
    {
        return population;
    }

    public void SetAreaCode(int code)
    {
        areaCode = code;
    }

    public int GetAreaCode()
    {
        return areaCode;
    }

    public void SetDistricts(string[] districts)
    {
        this.districts = districts;
    }

    public string[] GetDistricts()
    {
        return districts;
    }

    public void DisplayCityInfo()
    {
        Console.WriteLine($"City: {cityName}");
        Console.WriteLine($"Country: {countryName}");
        Console.WriteLine($"Population: {population}");
        Console.WriteLine($"Area Code: {areaCode}");
        Console.WriteLine("Districts:");
        foreach (string district in districts)
        {
            Console.WriteLine($"- {district}");
        }
    }
}

class Program
{
    static void Main()
    {
        string[] districts = { "District 1", "District 2", "District 3" };

        City city = new City("Kyiv", "Ukraine", 2800000, 44, districts);
        city.DisplayCityInfo();
    }
}
