using ComLibrary.Enums;
using ComLibrary.models;
using System;
using System.Collections.Generic;
using System.Text;
public class SalePerson : Employee
{
    private double SeccessSaleRavenue { get; set; }
    public string FirstName { get; }
    public string LastName { get; }
    public int Salary { get; }
    public RoleType Role { get; }

    public SalePerson(string first, string last)
    {
        FirstName = first;
        LastName = last;
        Salary = 500;
        Role = RoleType.Sales;
    }
    public void ExtenndSuccessSaleRevenue(int successValue)
    {
        SeccessSaleRavenue += successValue;
    }
    public override double GetSalary()
    {
        if (SeccessSaleRavenue <= 2000)
        {
            return Salary + 500;
        }
        else if (SeccessSaleRavenue <= 5000)
        {
            return Salary + 800;
        }
        else if (SeccessSaleRavenue > 5000)
        {
            return Salary + 2000;
        }
        else
        {
            return Salary;
        }
    }
}
