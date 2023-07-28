//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Arrays
//{
//    internal class Sorting
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter the no of elements in the array: ");
//            int size = Convert.ToInt32(Console.ReadLine());
//            int[] array = new int[size];
//            Console.WriteLine("Enter the array elements: ");
//            for (int i = 0; i < size; i++)
//            {

//                Console.WriteLine($"Enter the value {i+1}:");
//                array[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            Console.WriteLine("reversed array for integer:");
//            Array.Sort(array);
//            Array.Reverse(array);
//            foreach (int i in array)
//            {
//                Console.Write(i + "\t");
//            }
//            Console.Write("Please enter array size:");
//            int sizeChar = Convert.ToInt32(Console.ReadLine());
//            char[] arrayChar = new char[sizeChar];
//            Console.WriteLine("Enter characters");
//            for (int j = 0; j < sizeChar; j++)
//            {
//                Console.WriteLine($"Enter the character {j+1}:");
//                arrayChar[j] = Convert.ToChar(Console.ReadLine());

//            }
//            Console.WriteLine("reversed array for number:");
//            Array.Sort(arrayChar);
//            Array.Reverse(arrayChar);
//            foreach (char j in arrayChar)
//            {
//                Console.Write(j + "\t");
//            }


//            Console.ReadLine();
//        }
//    }
//}