using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    struct Trainee
    {
        public string name;
        public bool Ispresent;
    }
    internal class Attendance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total number of students in the class: ");
            int num=Convert.ToInt32(Console.ReadLine());
            Trainee[] trainees = new Trainee[num];
            for(int i = 0;i < trainees.Length; i++)
            {
                Console.WriteLine($"Enter the student name {i + 1}");
                trainees[i].name = Console.ReadLine();
            }
            for(int i = 0; i < trainees.Length; i++)
            {
                Console.WriteLine($"{trainees[i].name} is present:(y/n):");
                string status=Console.ReadLine();
                trainees[i].Ispresent=(status=="y");
            }
            int pres = 0, abs = 0;
            for(int i=0;i < trainees.Length;i++)
            {
                if (trainees[i].Ispresent)
                {
                    pres++;
                }
                else
                {
                    abs++;
                }
            }
            Console.WriteLine($"Total students present in today:{pres}");
            Console.WriteLine($"Total students absent in today:{abs}");
        }
    }
}
