using System;
using System.Collections.Generic;

public class Country
{
    public string Name;
    public string Continent;
    public int Population;
    public string AreaCode;
    public string Capital;
    public List<string> Cities;

    public Country(string name, string continent, int population, string areaCode, string capital, List<string> cities)
    {
        Name = name;
        Continent = continent;
        Population = population;
        AreaCode = areaCode;
        Capital = capital;
        Cities = cities;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"Country: {Name}");
        Console.WriteLine($"Continent: {Continent}");
        Console.WriteLine($"Population: {Population}");
        Console.WriteLine($"Area Code: {AreaCode}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine("Cities: " + String.Join(", ", Cities));
    }

    static void Main()
    {
        Country ukraine = new Country("Ukraine", "Europe", 41000000, "+380", "Kyiv", new List<string> { "Kyiv", "Odesa", "Lviv" });
        Country germany = new Country("Germany", "Europe", 83000000, "+49", "Berlin", new List<string> { "Berlin", "Munich", "Hamburg" });

        ukraine.DisplayInformation();
        Console.WriteLine();
        germany.DisplayInformation();
    }
}
