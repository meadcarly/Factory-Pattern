namespace FactoryPattern;
//Create 2 new public classes that will conform to IVehicle.
public class SemiTruck : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Building a new semi-truck.");
    }
}