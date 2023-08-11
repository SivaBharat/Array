using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Tuplecg
    {
        public int Id;
        public string Name;
        public double Salary;
    }
    internal class Cgdemo
    {
        static void Main(string[] args)
        {
            List<(int,string,double)> list = new List<(int,string,double)>
            {
                (101,"Siva",20000),
                (102,"Arun",21000),
                (103,"Srikanth",22000)
            };
        }
    }
}
