namespace FactoryPattern;
//Now we will make our static VehicleFactory class. It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter Call this functionality in the Main method.
public static class VehicleFactory
{
    public static IVehicle GetVehicle(int tires)
    {
        switch (tires)
        {
            case 2:
                return new Motorcycle();
            case 4:
                return new Car();
            case 18:
                return new SemiTruck();
            default:
                return new Car();
        }
    }
}