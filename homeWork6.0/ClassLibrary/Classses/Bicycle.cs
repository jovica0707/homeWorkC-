using ClassLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classses
{
    public class Bicycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        protected bool IsElectric { get; set; }

        public void Ride()
        {
            Console.WriteLine("The bicycle is ready to ride");
        }

        public override void Repair()
        {
            Console.WriteLine($@"The vehicle Id: {Id}, Manufacturer: {Manufacturer}, Model: {Model}, Type: {Type}, Number of weels: {NumberOfWheels}, 
                                Number of speed levels: {NumberOfSpeedLevels} - was brought for repair in the bicycle shop");
        }

        public Bicycle() : base(WheeledVehicleType.bicycle)
        {
            IsElectric = true;
            Console.WriteLine(IsElectric ? "Electric bicycles must be brought in specialized repair shops" : "Non electric bicycles can be" +
                " brought to regular repair shops");
        }
    }
}