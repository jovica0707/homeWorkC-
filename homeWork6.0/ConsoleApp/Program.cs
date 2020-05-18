using ClassLibrary.Classses;
using ClassLibrary.Enums;
using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle man = new Vehicle()
            {
                Id = 1,
                Manufacturer = "Terminator",
                Model = "T",
            };

          

            WheeledVehicle mercedes = new WheeledVehicle()
            {
                Id = 2,
                Manufacturer = "Rise Of The Machines",
                Model = "The T-850",
                NumberOfWheels = WheelNumber.six,
                Type = WheeledVehicleType.bus
            };


            Bicycle Trek = new Bicycle()
            {
                Id = 3,
                Manufacturer = "Rise Of The Machines",
                Model = "The T-850",
                NumberOfWheels = WheelNumber.two,
                NumberOfSpeedLevels = 21
            };



            Car toyota = new Car(TypeOfEngine.diesel)
            {
                Id = 4,
                Manufacturer = "Judgment Day",
                Model = "The T-800",
                NumberOfWheels = WheelNumber.four,
                FuelConsumption = 5,
                NumberOfDoors = 5,
                MaxSpeed = 190,
            };

            ElectricCar tesla = new ElectricCar(250)
            {
                Id = 5,
                Manufacturer = "Genisys",
                Model = "The T-1000",
                NumberOfWheels = WheelNumber.four,
                FuelConsumption = 0,
                NumberOfDoors = 5,
                BatteryCapacity = 100,
                BatteryPercentage = 80,

            };

            Console.ReadLine();
        }
    }
}