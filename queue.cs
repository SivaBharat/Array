using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public partial class Partialclass
    {
        public partial void displayq()
        {
            //Queue Performance
            Queue myQueue = new Queue();
            myQueue.Enqueue("one");
            myQueue.Enqueue("two");
            myQueue.Enqueue("three");
            myQueue.Enqueue("four");
            Console.WriteLine("Queue Elements: ");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
            myQueue.Dequeue();
            Console.WriteLine("Queue Elements after deleting: ");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            } 
        }
         public partial void link()
         {            
            LinkedList<string> myLinkedList = new LinkedList<string>();
            myLinkedList.AddLast("Siva");
            myLinkedList.AddLast("Arun");
            myLinkedList.AddLast("Karthi");
            myLinkedList.AddLast("Srikanth");
            Console.WriteLine("Linked List elements:");
            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }
            myLinkedList.Remove("Siva");
            Console.WriteLine("Linked list elements after removing:");
            foreach (var item in myLinkedList)
            {
                Console.WriteLine(item);
            }
        }
        public partial void Hash()
        {
            HashSet<int> find = new HashSet<int>();

            for (int i = 1; i <= 10; i++)
            {
                find.Add(i);
            }

            int search;
            Console.WriteLine("Enter an integer to search");
            search = Convert.ToInt32(Console.ReadLine());

            if (find.Add(search))
            {
                Console.WriteLine("Element was not found and was added now");
            }

            else
            {
                Console.WriteLine("Element found");
            }

            Console.WriteLine("The hash set elements are");
            foreach (int i in find)
            {
                Console.Write(i + "\t");
            }
        }

    }
}

