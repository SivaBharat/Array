using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Array
{
    internal class Colordemo
    {
        public void multithread()
        {
            Console.WriteLine("Main thread started");
            Thread t1 = new Thread(method1)
            {
                Name = "Thread_A"
            };
            Thread t2 = new Thread(method2)
            {
                Name="Thread_B"
            };
            Thread t3 = new Thread(method3)
            {
                Name="Thread_c"
            };
            t1.Priority= ThreadPriority.Normal;
            t2.Priority=ThreadPriority.Highest;
            t3.Priority =ThreadPriority.Lowest;
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main thread ended");
        }
        static void method1()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.BackgroundColor= ConsoleColor.Red;
            for(int i = 0;i< 10; i++)
            {
                Console.WriteLine("Siva from method one");
                Thread.Sleep(1000);
            }
        }
        static void method2()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.BackgroundColor= ConsoleColor.Yellow;
            for(int i=0;i< 10; i++)
            {
                Console.WriteLine("Arun from method two");
                Thread.Sleep(2000);
            }
        }
        static void method3()
        {
            Console.ForegroundColor= ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            for( int i=0;i< 10; i++)
            {
                Console.WriteLine("Vicky from method three");
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            Colordemo colordemo = new Colordemo();
            colordemo.multithread();
            Console.ReadKey();
        }
    }
}
