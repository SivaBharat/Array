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
        public virtual void Display()
        {
            Console.WriteLine($"Employee id is:{id}");
            Console.WriteLine($"Employee name is:{name}");
            Console.WriteLine($"Employee salary is:{salary}");
        }
    }
    public class Hr : Employees
    {
        public double bonus { get; set; }
        public new void Details()
        {
            base.Display();
            Console.WriteLine($"The employee bonus is:{bonus}");
        }
        internal class Virtualdemo
        {
            public static void Main(string[] args)
            {
                Hr hr = new Hr { id=123,name="Siva",salary=30000,bonus=2000};
                hr.Details();
            }
        }
    }
}
