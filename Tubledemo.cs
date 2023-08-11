using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Tubledemo
    {             
        static Hashtable cg = new Hashtable();
        static Hashtable g2 = new Hashtable();  
        public static void company(Tuple<int,string,string> tuple)
        {
            if(tuple.Item3.ToLower() == "cg-vak")
            {
              cg.Add(tuple.Item1, tuple.Item2);
            }
            else if(tuple.Item3.ToLower() =="g2")
            {
                g2.Add(tuple.Item1, tuple.Item2);
            }
            else
            {
                Console.WriteLine("Invalid Company name");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees:");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<num; i++)
            {
                Console.WriteLine($"Enter the {i + 1}th Employee id:");
                int id=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the {i + 1}th employee name:");
                string name=Console.ReadLine();
                Console.WriteLine($"Enter the {i + 1}th employee company name:");
                string company_name=Console.ReadLine();
                var tuple=new Tuple<int,string,string>(id,name,company_name);
                company(tuple);
            }
            Console.WriteLine("Cg employees details:");
            foreach(DictionaryEntry cgv in  cg)
            {
                Console.WriteLine($"Employee id:{cgv.Key} Employee name:{cgv.Value}");
            }
            Console.WriteLine("G2 employees details");
            foreach(DictionaryEntry g in g2)
            {
                Console.WriteLine($"Employee id:{g.Key} Employee name:{g.Value}");
            }
        }

    }
}
