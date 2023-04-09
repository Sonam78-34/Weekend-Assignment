using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Car
{
    public class Car
    { 
        Engine engine=new Engine();
        FuelTank fuelTank= new FuelTank();
        //Car2 car2= new Car2();
    public class Engine
    {
        private bool running;
        private const double fuleConsumption = 0.0003;
        double fuelConsumption = 0.003;
        public double fuelConsumed;

        public void EnginePhase(String stateOfCar)
        {
               string  string1 = "yes";
            if (string.Compare(string1, stateOfCar)==0)
            {
                running = true;
            }
            else
            {
                running = false;

            }
        }

        //how much fuel has consumed
        public double Run(int seconds)
        {
            if (running)
            {
                fuelConsumed = fuelConsumption * seconds;


                if (fuelConsumed <= 0)
                {
                    Console.WriteLine("Car has not started so fuel consumption is zero");
                }

            }
            Console.WriteLine("The fuel Consumed by engine is {0}", fuelConsumed);
            return fuelConsumed;
        }

    }

    public class FuelTank
    {
        const double fuelLevel = 20;
        const double fuelTankSize = 60;
        double reserveLevel = 5.0;

         public double level = fuelLevel;


        //to get the final fuel level
        public double fuelLevelChanges(double fuelAddedAmount)
        {
            if (fuelAddedAmount >= 0)
            {
                level += fuelAddedAmount;
            }

            return level;
        }

        //to get the remaining fuel level
        Engine engine = new Engine();
        double availableFuel = 0;
        public void AvailableFuel()
        {
            availableFuel = level - engine.fuelConsumed;
            Console.WriteLine("The available fuel level is {0}", availableFuel);
        }

        //avaliablefuel is less than or 5
        public void resevedFuel()
        {
            if (availableFuel <= reserveLevel)
            {
                Console.WriteLine("The fuel is less and it is reserve");
            }
        }

    }
}



    public class Car2 : Car
    {
         Engine engine= new Engine();
         const int intialAcceleration = 10;
        int minimumAcceleration = 5;
        int maximumAcceleration = 20;
        int maximumSpeed = 250;
       public  double speed;
        public double fuelConsumed;
        public double speedAfterAcceleration;
        public double speedAfterbraking;
        public double speedAfterFreewheeling;

        public void Aceleration(int typeOfAction, int acceleration, int speed, int seconds)
        {
            if (acceleration >= minimumAcceleration && acceleration <= maximumAcceleration)
            {
                switch (typeOfAction)
                {
                    case 1:
                        speed = speed + acceleration;

                          speedAfterAcceleration = speed;
                        break;
                    case 2:
                        speed = speed - acceleration;
                        double speedAfterbraking = speed;
                       break;
                    case 3:
                        speed = speed - 1;
                        speedAfterFreewheeling = speed;
                        break;
                }
            }
                        
            Console.WriteLine("The updated speed after action  is {0}",speed);
            if (speed >= 1 && speed < maximumSpeed)
             {
                    if (speed >= 1 && speed <= 60)
                    {
                        double fuelConsumption = 0.0020;
                        fuelConsumed = fuelConsumption * seconds;
                        
                    }
                    else if (speed >= 61 && speed <= 100)
                    {
                        double fuelConsumption = 0.0014;
                        fuelConsumed = fuelConsumption * seconds;
             
                    }
                    else if (speed >= 101 && speed <= 140)
                    {
                        double fuelConsumption = 0.0020;
                        fuelConsumed = fuelConsumption * seconds;
                    }
                    else if (speed >= 141 && speed <= 200)
                    {
                        double fuelConsumption = 0.0025;
                        fuelConsumed = fuelConsumption * seconds;
                    }
                    else if (speed >= 200 && speed <= 250)
                    {
                        double fuelConsumption = 0.0030;
                        fuelConsumed = fuelConsumption * seconds;
                    }

                }
                Console.WriteLine("The fuel has consumed after driving with acceleration is {0}", fuelConsumed);
                //for fuel leve
                FuelTank fuelTank = new FuelTank();
                double availableFuelLevel = fuelTank.level - fuelConsumed;
                Console.WriteLine(" The fuel left after accleration is {0}", availableFuelLevel);

            
        }
    }
    public class Car3 
    {
        Car2 car2 = new Car2();

        public void onBoardComputer(int seconds)
        {
            Console.WriteLine("Total driving time is {0}",seconds);

            double totalDrivenDistance = car2.speed * seconds;
            Console.WriteLine("Total drivend distance is {0}", totalDrivenDistance);

            double actualSpeed = car2.speed;
            Console.WriteLine("The actual speed is {0}",actualSpeed);

            double averageSpeed = (car2.speedAfterAcceleration + car2.speedAfterbraking + car2.speedAfterFreewheeling)/3;
            Console.WriteLine("The average speed is {0}",averageSpeed);


            //time =distance/speed
            double actualConsumptionByTime = car2.fuelConsumed*100/ seconds;
            Console.WriteLine("The acutal consumption by time is  {0}", actualConsumptionByTime);

            double actualConsumptionByDistance = car2.fuelConsumed * 100 / totalDrivenDistance;
            Console.WriteLine("The acutal consumption by distance is {0} ",actualConsumptionByDistance);


        }
    }
    
}

