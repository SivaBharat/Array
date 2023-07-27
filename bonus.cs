using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class bonus
    {
        static void Main(string[] args)
        {
            int i, num;
            Console.WriteLine("Enter the number of employees:");
            num = Convert.ToInt32(Console.ReadLine());
            int[] id = new int[num];
            string[] name = new string[num];
            double[] salary = new double[num];
            double[] bonus = new double[num];

            for (i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter the employee {i + 1} id ");
                id[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter the employee {i + 1} name ");
                name[i] = Console.ReadLine();

                Console.WriteLine($"Enter the employee {i + 1} salary ");
                salary[i] = Convert.ToDouble(Console.ReadLine());

               
                CalculateBonus(salary[i], out bonus[i]);
            }

            Console.WriteLine("Employee Details:");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine("Employee id: " + id[i]);
                Console.WriteLine("Employee name: " + name[i]);
                Console.WriteLine("Employee salary: " + salary[i]);
                Console.WriteLine("Employee bonus: " + bonus[i]);
                Console.WriteLine("-------------------------------");
            }
        }

        static void CalculateBonus(double salary, out double bonus)
        {            
            bonus = 0.10 * salary;
        }
    }
}
