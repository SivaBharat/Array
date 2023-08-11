using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Asyncdemo
    {
        static int sum = 0;
        static int mul=1;
        static async Task<int> Sum(int n)
        {          
            
            for (int i = 1; i < n;i++)
            {
                sum += i;
            }
            await Task.Delay(5000);
            return sum;
            
        }
        static async Task<int> Mul(int n)
        {           
            
            for(int i=1; i < n; i++)
            {
                mul *= i;
            }
            await Task.Delay(1000);            
            return mul;
        }
      public static async Task Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            Task<int> s= Sum(n);
            Task<int> p =  Mul(n);
            var prod = await p;
            Console.WriteLine(prod);
            var sum = await s;            
            Console.WriteLine(sum);                        
        }
    }
}
