using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Enumdemo
    {
        public enum shapes
        {
            circle,
            rectangle,
            square
        }
        
        public static void area(int number1, shapes structure, params object[] number2)
        {
            if ((int)structure == 0)
            {
                Console.WriteLine("Area of circle:" + 3.14 * number1 * number1);
            }
            else if ((int)structure == 2)
            {
                Console.WriteLine("Area of square:" + number1 * number1);
            }
            else if ((int)structure == 1)
            {
                foreach (int i in number2)
                    Console.WriteLine("Area of rectangle:" + number1 * i);
            }

        }
        public static void iteration(int number1, params object[] number2)
        {
            Console.WriteLine("Iteration method");
            foreach (Enum shape in Enum.GetValues(typeof(shapes)))
            {
                if (shape.ToString() == "circle")
                {
                    Console.WriteLine("Area of circle:" + 3.14 * number1 * number1);
                }
                else if (shape.ToString() == "rectangle")
                {
                    foreach (int i in number2)
                        Console.WriteLine("Area of rectangle:" + number1 * i);
                }
                else if (shape.ToString() == "square")
                {
                    Console.WriteLine("Area of square:" + number1 * number1);
                }
            }
        }
       public static void Main(string[] args)
        {
            area( 5,shapes.circle);
            area(7,  shapes.square);
            area(10, shapes.rectangle, 15);

            iteration(3, 2);
            
        }
    }
}