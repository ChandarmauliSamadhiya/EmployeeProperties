using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public partial class Employee
{
    public double CalculateSalary()
    {
       
        double totalSalary = BaseSalary + CalculateBonus() - CalculateDeductions();
        return totalSalary;
    }

    private double CalculateBonus()
    {

        return BaseSalary * 0.1;
    }

    private double CalculateDeductions()
    {
        
        return 200;
    }
}
