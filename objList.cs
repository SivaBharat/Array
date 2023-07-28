using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class objList
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public objList()
        {

            Console.Write("Id:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Age:");
            age = Convert.ToInt32(Console.ReadLine());

        }
        public void displayFunction(objList prgObj)
        {
            id = prgObj.id;
            name = prgObj.name;
            age = prgObj.age;
            Console.WriteLine($"Id:{id},Name:{name},Age:{age}");

        }
        static void Main(string[] args)
        {
            objList prgObj = new objList();
            prgObj.displayFunction(prgObj);
        }
    }  
   
}
