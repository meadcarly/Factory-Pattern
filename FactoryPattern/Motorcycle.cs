namespace FactoryPattern;
//Create 2 new public classes that will conform to IVehicle.
public class Motorcycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Building a new motorcycle.");
    }
}