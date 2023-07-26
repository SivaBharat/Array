using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class bonus
    {
        static void Main(string[] args)
        {
            int i, num,id;
            double bonus,salary;
            string name;
            Console.WriteLine("enter the number of employees:");
            num=Convert.ToInt32(Console.ReadLine());
            for(i=0; i < num;i++)
            {
                Console.WriteLine($"Enter the employee {i + 1} id ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the employee {i + 1} name ");
                name= Console.ReadLine();
                Console.WriteLine($"Enter the employee {i+1} salary ");
                salary=Convert.ToInt32(Console.ReadLine());
                bonus=Convert.ToInt32(Console.ReadLine());    

            }

        }
    }
}
