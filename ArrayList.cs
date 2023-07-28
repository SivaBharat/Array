using System;
using System.Collections;
using System.ComponentModel;

namespace Array
{
    public class ArrayLis
    {
        public void display()
        {
            ArrayList arrayList = new ArrayList();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the value {i + 1}");
                var j=Console.ReadLine();
                if (j == "")
                {
                    arrayList.Add(null);
                }
                arrayList.Add(j);   
            }
            foreach(object  obj in arrayList)
            {
                if(obj == null)
                {
                    Console.WriteLine("I have a value");
                    continue;
                }
                Console.WriteLine(obj.ToString());
            }
        }
        static void Main(string[] args)
        {
            ArrayLis arrayLis = new ArrayLis();
            arrayLis.display();
        }
    }
}
