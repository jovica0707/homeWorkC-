using ComLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComLibrary.models
{
    public class SalesPeroson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPeroson(string first, string last)
        {
            FirstName = first;
            LastName = last;
            Salary = 500;
            Role = RoleType.Sales;
        }

        public void ExtendSuccessSaleRevenue(int successValue)
        {
            SuccessSaleRevenue += successValue;
        }

        public override double GetSalary()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                return Salary + 2000;
            }
            else
            {
                return Salary;
            }
        }
    }
    
}
