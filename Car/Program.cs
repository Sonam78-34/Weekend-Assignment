using System.Threading.Channels;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Car car = new Car();
         Car.Engine engine = new Car.Engine();
         Car.FuelTank fuelTank = new Car.FuelTank();

            Console.WriteLine("Engine has started then yes or not started then type No");
            String stateOfCar=Console.ReadLine();

            Console.WriteLine("Enter the number of seconds it has run");
            int seconds = int.Parse(Console.ReadLine());
     
            engine.EnginePhase(stateOfCar);
            engine.Run(seconds);

            //object for fueltank

           // Car.FuelTank fuelTank = new Car.FuelTank();
            Console.WriteLine("Enter the extra fuel added amount");
            double fuelAddedAmount= double.Parse(Console.ReadLine());

            fuelTank.fuelLevelChanges(fuelAddedAmount);
           
            fuelTank.AvailableFuel();
            fuelTank.resevedFuel();



            /// for the second step
            /// for acceleration
           Car2 car2 = new Car2();
            Console.WriteLine("Enter the type of action 1 for acceleration, 2 for beak ,3 for freewheeling");
            int typeOfaction=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acceleration");
            int acceleration= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the speed");
            int speed=int.Parse(Console.ReadLine());


            car2.Aceleration(typeOfaction,acceleration, speed, seconds);

            /// for car 3
            Car3 car3 = new Car3();
            car3.onBoardComputer(seconds);

        }
    }
}