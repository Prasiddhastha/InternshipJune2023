namespace ConsoleApp2.Models;

public record Manufacturer(int Id, string name, Country country);

public record Vehicle(Manufacturer manufacturer, string model);


public enum Country
{
    Germany = 1,
    Italy = 2,
    France = 3,
    China = 4,
    UnitedKingdom = 5
}
