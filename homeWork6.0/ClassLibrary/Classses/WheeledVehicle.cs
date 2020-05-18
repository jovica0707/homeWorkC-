using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classses
{
    public class WheeledVehicle : Vehicle
    {
        public WheelNumber NumberOfWheels { get; set; }
        public WheeledVehicleType Type { get; set; }

        public virtual void Repair()
        {
            Console.WriteLine($"The vehicle Id: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Type: {Type}, Number of wheels: {NumberOfWheels}" +
                $" - was brought for repair");
        }

        public WheeledVehicle()
        {
            Console.WriteLine("Primary production line");
        }

        public WheeledVehicle(WheeledVehicleType type)
        {
            Type = type;
            Console.WriteLine("Secondary production line");
        }

    }
}