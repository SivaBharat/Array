using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Swaping
    {
        public class genericClass<T1, T2, T3>
        {
            public genericClass(T1 val1, T2 val2, T3 val3)
            {
                Console.WriteLine("value:{0}", typeof(T1), val1);
                Console.WriteLine("value:{0}", typeof(T2), val2);
                Console.WriteLine("value:{0}", typeof(T3), val3);

            }
        }
        static void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter character 1:");
            char char1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter character 2:");
            char char2 = Convert.ToChar(Console.ReadLine());

            Swap<int>(ref num1, ref num2);
            Swap<char>(ref char1, ref char2);

            Console.WriteLine("After swaping number");
            Console.WriteLine("number 1:{0},number 2:{1}", num1, num2 + "\n");


            Console.WriteLine("After swaping Char");
            Console.WriteLine("Char1:{0},char2:{1}", char1, char2);

            //Generic to identify the datatype
            genericClass<int, char, string> generic1 = new genericClass<int, char, string>(10, 'c', "String");
            Console.Write(generic1);
        }
    }
}
