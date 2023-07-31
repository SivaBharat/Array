using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
   public abstract class Employee
    {
        public string name;
        public double income; 
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Income
        {
            get { return income; }
            set { income = value; }
        }
        public abstract double tax();
    }
    public class Salone : Employee
    {
        public override double tax()
        {
            return income*0.01;
        }
    }
    public class Saltwo : Employee
    {
        public override double tax()
        {
            return Income*0.02;
        }
    }
    public class Salthree : Employee
    {
        public override double tax()
        {
            return Income*0.03;
        }
    }
    internal class Abstractiondemo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Income: ");
            double income = Convert.ToDouble(Console.ReadLine());
            Employee employee;
            if (income <= 50000)
            {
              employee = new Salone();
            }
            else if(income <= 100000)
            {
              employee = new Saltwo();
            }
            else
            {
              employee = new Salthree();
            }

           employee.Name=name;
           employee.Income = income;
           Console.WriteLine($"{name}'s tax amount is {employee.tax()}");
        }
    }
}
