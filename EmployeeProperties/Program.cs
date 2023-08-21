using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.FirstName = "John";
        employee.LastName = "Doe";
        employee.Age = 30;
        employee.BaseSalary = 50000;

        double salary = employee.CalculateSalary();
        Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} earns a salary of ${salary}");
        Console.ReadLine();
    }
}
