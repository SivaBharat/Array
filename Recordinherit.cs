using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public record class Players
    {
        public void display()
        {
            Console.WriteLine("Players category");
        }
    }
    public record class Grade1 : Players
    {
        public void display1()
        {
            Console.WriteLine("Grade one players");
        }
    }
    public record class Grade2 : Players
    {
        public void display2()
        {
            Console.WriteLine("Grade two players");
        }
    }
    internal class Recordinherit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base class record");
            Players p=new Players();
            p.display();
            Console.WriteLine("First Child class record");
            Grade1 g=new Grade1();
            g.display();
            g.display1();
            Console.WriteLine("Second child class record");
            Grade2 grade2 = new Grade2();
            grade2.display();
            grade2.display2();
        }
    }
}
