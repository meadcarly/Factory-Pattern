namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires are on the vehicle? (2, 4, or 18?");
            int tireNumber; 
            int.TryParse(Console.ReadLine(), out tireNumber);
            
            var vehicle = VehicleFactory.GetVehicle(tireNumber);
            
            vehicle.Drive();
            
        }
    }
}
