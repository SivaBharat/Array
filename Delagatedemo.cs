using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    //Delegate for purchase amount
    delegate double CalculateDiscount(double totalCost);

    class Delagatedemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total purchasing amount: ");
            double purchaseAmount = Convert.ToDouble(Console.ReadLine());
            CalculateDiscount couponCodeDiscount;
            couponCodeDiscount = ApplyCouponCode;
            double discount = couponCodeDiscount(purchaseAmount);
            double finalCost = purchaseAmount - discount;
            Console.WriteLine($"Total purchase amount: {purchaseAmount}");
            Console.WriteLine($"Your discount amount is: {discount}");
            Console.WriteLine($"Your total cost is: {finalCost}");
            Console.WriteLine("-----------------------------------------------------");
            // Multiplication table
            Func<int, int, int> multiplicationTable = GenerateMultiplicationTable;
            Console.WriteLine("Enter the number to generate the multiplication table");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                int result = multiplicationTable(number, i);
                Console.WriteLine($"{number} * {i} = {result}");
            }
            Console.WriteLine("----------------------------------------------------");
            //Todo list
            Action<List<string>, string> todoList = AddTodoItem;
            List<string> list = new List<string>();
            todoList(list, "Cricket");
            todoList(list, "Football");
            todoList(list, "Volleyball");
            Console.WriteLine("Todo List");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------------------------");
        }
        
        static double ApplyCouponCode(double totalCost)
        {
            if (totalCost > 2000)
            {
                return totalCost * 0.10;
            }
            else
            {
                return 0;
            }
        }

        static int GenerateMultiplicationTable(int number, int multiplier)
        {
            return number * multiplier;
        }

        static void AddTodoItem(List<string> list, string item)
        {
            list.Add(item);
        }
    }
}
