using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Array
{
    class Employee1
    {
      public string name { get; set; }
      public int age { get; set; }
      public double salary { get; set; }
      public double bonus { get; set; }
      public event EventHandler<EmployeeEventArgs> BonusCalculated;
        public void CalculateBonus(double bonusPercentage)
        {
            bonus = salary * bonusPercentage / 100;
            OnBonusCalculated(new EmployeeEventArgs(this));
        }
        protected virtual void OnBonusCalculated(EmployeeEventArgs e)
        {
            BonusCalculated?.Invoke(this, e);
        }
    }
    class EmployeeEventArgs:EventArgs
    {
     public Employee1 Employee1 { get;}
        public EmployeeEventArgs(Employee1 employee1)
        {
            Employee1 = employee1;
        }
    }
    class EmployeeValidator
    {
        public static bool ValidateName(string name)
        {
            string pattern = @"^[A-Za-z\s]+$";
            return Regex.IsMatch(name, pattern);
        }
        public static bool ValidateAge(int age)
        {
            string pattern = @"^\d+$";
            return Regex.IsMatch(age.ToString(), pattern);
        }
        public static bool ValidateSalary(double salary)
        {
            string pattern= @"^\d+$";
            return Regex.IsMatch(salary.ToString(), pattern);
        }
    }
    internal class Eventdemo
    {
        static void Main(string[] args)
        {
            Employee1 employee1 = new Employee1();
            Console.WriteLine("Enter the employee name:");
            string name = Console.ReadLine();
            if (!EmployeeValidator.ValidateName(name))
            {
                Console.WriteLine("Invalid name.Name contains only characters.");
                return;
            }
            Console.WriteLine("Enter the employee age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (!EmployeeValidator.ValidateAge(age))
            {
                Console.WriteLine("Invalid age.");
                return;
            }
            Console.WriteLine("Enter he employee salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (!EmployeeValidator.ValidateSalary(salary))
            {
                Console.WriteLine("Invalid salary");
                return;
            }
            employee1.name = name;
            employee1.age = age;
            employee1.salary = salary;
            employee1.BonusCalculated += (sender, e) =>
            {
                Console.WriteLine("Employee details:");
                Console.WriteLine($"Employee name:{e.Employee1.name}");
                Console.WriteLine($"Employee age:{e.Employee1.age}");
                Console.WriteLine($"Employee salary:{e.Employee1.salary}");
                Console.WriteLine($"Employee bonus:{e.Employee1.bonus}");
            };
            employee1.CalculateBonus(10);
            Console.ReadLine();
           } 
    }
}
