namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tireCount;
            bool input = false;
            do
            {
                Console.WriteLine("How many tires does your vehicle have (2 or 4)?");

                input = int.TryParse(Console.ReadLine(), out tireCount);

                var myVehicle = VehicleFactory.GetVehicle(tireCount);
            } while (input== false);
            
            var vehicle = VehicleFactory.GetVehicle(tireCount);
            vehicle.Drive();
        }
    }
}