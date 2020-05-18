using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classses
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Id: {Id}, Manufacturer: {Manufacturer}, Model: {Model}");
        }

        public Vehicle()
        {
            Console.WriteLine("Main Factory");
        }
    }
}