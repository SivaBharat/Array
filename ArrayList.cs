using System;
using System.Collections;

namespace Array
{
    internal class ArrayLis
    {
        static void Main()
        {
            ArrayList mixedList = new ArrayList();
            mixedList.Add("Siva");
            mixedList.Add(null);
            mixedList.Add("Arun");
            mixedList.Add(null);
            mixedList.Add("Karthi");
            mixedList.Add(null);

            Console.WriteLine("Original ArrayList:");
            PrintArrayList(mixedList);

            
            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] == null)
                {
                    mixedList[i] = "I have a value";
                }
            }

            Console.WriteLine("\nUpdated ArrayList:");
            PrintArrayList(mixedList);
        }

        static void PrintArrayList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
