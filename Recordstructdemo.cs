using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { }
    public record struct Employee
    {
        public int ID { get; init; }
        public string Name { get; init; }       
        public double Salary;
        public double Bonus;
        public static void Display(Employee employee)
        {
            if (employee.Salary > 50000)
            {
                employee.Bonus = (employee.Salary * 20) / 100;
                employee.Salary += employee.Bonus;
            }
            else if (employee.Salary < 50000 && employee.Salary >= 25000)
            {
                employee.Bonus = (employee.Salary * 15) / 100;
                employee.Salary += employee.Bonus;
            }
            else
            {
                employee.Bonus = (employee.Salary * 10) / 100;
                employee.Salary += employee.Bonus;
            }            
            Console.WriteLine("\nEmployee Details: ");
            Console.WriteLine($"Employee ID: {employee.ID}");
            Console.WriteLine($"Employee Name: {employee.Name}");            
            Console.WriteLine($"Bonus: {employee.Bonus}");
            Console.WriteLine($"Total salary with bonus: {employee.Salary}");
        }
    }
    internal class Recordstructdemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Employees");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Employee details:");
                Console.WriteLine($"Enter the {i+1}th Employee ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the {i+1}th Employee Name");
                string name = Console.ReadLine();
                Console.WriteLine($"Enter the {i+1}th employee Designation");
                string des = Console.ReadLine();
                Console.WriteLine($"Enter the {i+1}th employee Salary");
                double sal = Convert.ToDouble(Console.ReadLine());
                var empRec = new Employee
                {
                    ID = id,
                    Salary = sal,
                    Name = name,                    
                };
                Employee.Display(empRec);
                Console.WriteLine("\n------------------------");
            }
            Console.ReadLine();
        }
    }
}