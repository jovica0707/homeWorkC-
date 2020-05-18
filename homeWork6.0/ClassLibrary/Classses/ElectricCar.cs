using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classses
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryPercentage { get; set; }
        public int MaxSpeedOnBattery { get; set; }

        public void Recharge()
        {
            Console.WriteLine("The car is recharging");
        }

        public override void Drive()
        {
            Console.WriteLine($"Electric car is ready to drive at maximum speed of {MaxSpeed} KM/H");
        }

        public override void Repair()
        {
            Console.WriteLine($@"The vehicle Id: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Type: {Type}, Number of wheels: {NumberOfWheels},
                                Engine Type: {EngineType}, Fuel consumption per 100km: {FuelConsumption}L, Number of Doors: {NumberOfDoors},
                                Max Speed: {MaxSpeed} KM/H, Max Speed on Battery: {MaxSpeedOnBattery} KM/H, Battery Capacity: {BatteryCapacity} kWh, 
                                    Battery Percentage: {BatteryPercentage} % - was brought for repair in the car dealership");
        }

        public ElectricCar(int num) : base(TypeOfEngine.electric)
        {
            MaxSpeed = num;
            MaxSpeedOnBattery = num / 2;

            Console.WriteLine("Electric car recieved in dealership");
        }

    }
}
