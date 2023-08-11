using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    //ReadOnly example
    public class Readonlyexample
    {
        public readonly int a;
        public Readonlyexample(int value)
        {
            a = value;
        }
    }
    //Const example
    public class ConstExample
    {
        public const double Pi = 3.14159;
    }
    //Static example
    public class StaticExample
    {
        public static int InstanceCount = 0;

        public StaticExample()
        {
            InstanceCount++;
        }
    }
    //Instance variable example
    public class InstanceVariableExample
    {
        public int InstanceValue;

        public InstanceVariableExample(int value)
        {
            InstanceValue = value;
        }
    }
    internal class Constdemo
    {
        static void Main(string[] args)
        {
            //Instance for the readonly class
            Readonlyexample obj1 = new Readonlyexample(10);
            Readonlyexample obj2 = new Readonlyexample(20);
            Console.WriteLine("Example of readonly:");
            Console.WriteLine(obj1.a);
            Console.WriteLine(obj2.a);
            //Print the const class
            Console.WriteLine("Example of const:");
            Console.WriteLine(ConstExample.Pi);
            //Instance for static example
            Console.WriteLine("Example of static:");
            StaticExample obj11 = new StaticExample();
            StaticExample obj22 = new StaticExample();
            Console.WriteLine(StaticExample.InstanceCount);
            //Instance variable
            Console.WriteLine("Example of instance variable:");
            InstanceVariableExample obj = new InstanceVariableExample(5);
            InstanceVariableExample objs = new InstanceVariableExample(10);
            Console.WriteLine(obj.InstanceValue);
            Console.WriteLine(objs.InstanceValue);
        }
    }
}