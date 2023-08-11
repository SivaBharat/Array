using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Commanddemo
    {
        static void Main(string[] args)
        {
            string name = Convert.ToString(args[0]);
            Console.WriteLine("Name: "+name);
            int age = Convert.ToInt32(args[1]);
            Console.WriteLine("Age: " + age);
        }
    }
}
