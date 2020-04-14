
using ComLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComLibrary.models
{
    class Employee
    {
        public string FirstName {get; set; }
        public string LastName { get; set; }
        public RoleType Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("First Name: {0}, Last Name: {1}, Salary: {2}", FirstName, LastName, Role, Salary);
        }

        public double GetSalary ()
        {
            return Salary;
        }
    }
}
