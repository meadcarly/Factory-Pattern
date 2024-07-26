namespace FactoryPattern;
//Create 2 new public classes that will conform to IVehicle.
public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Building a new Car.");
    }
}