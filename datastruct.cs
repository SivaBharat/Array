using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal partial class Siva
    {
        public  partial void hashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"Siva");
            ht.Add(2, "Arun");
            ht.Add(3, "Karthi");
            Console.WriteLine("The hashtable keys and values: ");
            foreach(DictionaryEntry i in ht)
            {
                Console.WriteLine("key: {0} value:{1}", i.Key, i.Value);
            }
        }
    }
}
