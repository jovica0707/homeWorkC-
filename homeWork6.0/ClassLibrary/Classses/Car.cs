using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classses
{
    public class Car : WheeledVehicle
    {
        protected TypeOfEngine EngineType { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("The car is ready to drive");
        }

        public override void Repair()
        {
            Console.WriteLine($@"The vehicle Id: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Type: {Type}, Number of wheels: {NumberOfWheels},
                Engine Type: {EngineType}, Fuel consumption per 100km: {FuelConsumption}L, Number of Doors: {NumberOfDoors},
                Max Speed: {MaxSpeed} KM/H - was brought for repair in the car dealership");
        }

        public Car() : base(WheeledVehicleType.car) { }

        public Car(TypeOfEngine type) : base(WheeledVehicleType.car)
        {
            EngineType = type;

            Console.WriteLine(EngineType == TypeOfEngine.electric ? "Elctric cars must be brought in specialized repair shops" : "Non electric cars can be" +
                " brought to regular repair shops");
        }

    }
}