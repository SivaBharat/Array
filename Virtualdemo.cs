using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Employees
    {
        public int id { get; set; }
        public string name { get; set; }
        public double salary { get; set; }
        public string Details() => $"{id} {name} {salary}";
        
    }
    public class Hr : Employees
    {
        public double bonus { get; set; }
        public new string Details() => $"{bonus}....{salary}";
    }
        internal class Virtualdemo
        {
            public static void Main(string[] args)
            {

            Console.WriteLine("enter salary:");
            double sal = Convert.ToInt64(Console.ReadLine());

            var display = new Hr()
            {
                salary = sal,
                id = 101,
                name = "Hari",
            };
             Console.WriteLine(display.Details());
             Employees emp = display;
             Console.WriteLine(emp.Details());

            Console.ReadLine();
        }
    }    
}