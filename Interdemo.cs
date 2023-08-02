using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public interface IRadius
    {
        public double Radius { get; set; }
        double Area();
    }
    public interface IWidth
    {
        public double Width { get; set; }
        public double Length { get; set; }
        double Area();
    }
    public class Circle : IRadius,IWidth
    {
        public double Radius { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
         double IWidth.Area()
        {
            return Length * Width;            
        }
         double IRadius.Area()
        {
            return 3.14*Radius*Radius;
        }
    }
        public class Interfacedemo
        {
            static void Main(string[] args)
            {
            IRadius circle = new Circle { Radius = 5 };
            IWidth rect = new Circle { Width = 10, Length = 15 };
            Console.WriteLine($"The area of the circle is: {circle.Area()}");
            Console.WriteLine($"The area of the rectangle is: {rect.Area()}");
            Console.ReadLine();
            }
        }
    }