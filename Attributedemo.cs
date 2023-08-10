using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Array
{
    internal class Attributedemo
    {
        static void Main(string[] args)
        {
            DisplayValueTypeMetadata();

            DisplayMathMethods();

            DisplayCurrentClassMethods();
        }
        static void DisplayValueTypeMetadata()
        {
            Console.WriteLine("Value type meta data");
            DisplayTypeMetadata(typeof(int));
            DisplayTypeMetadata(typeof(double));
            DisplayTypeMetadata(typeof(char));
            DisplayTypeMetadata(typeof(bool));
            DisplayTypeMetadata(typeof(string));
        }
        static void DisplayTypeMetadata(Type type)
        {
            Console.WriteLine($"Type:{type.Name}");
            Console.WriteLine($"Full name:{type.FullName}");
            Console.WriteLine($"Assembly:{type.Assembly.FullName}");
            Console.WriteLine();
        }
        static void DisplayMathMethods()
        {
            Console.WriteLine("Math methods");
            DisplayTypeMethods(typeof(Math));
        }
        static void DisplayCurrentClassMethods()
        {
            Console.WriteLine("Current class methods");
            DisplayTypeMethods(typeof(Attributedemo));
        }
        static void DisplayTypeMethods(Type type)
        {
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
        public void ExambleMethod1() { }
        private static void ExambleMethod2() { }
        protected void ExambleMethod3() { }
        public static int ExambleMethod4() => 10;
    }
}
