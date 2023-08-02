using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Array
{
    internal class Regularexpdemo
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Siva@123",
                "Bharath",
                "Siva",
            };
            Console.WriteLine("a. Password format -  at least 1(uppercase, lowercase, special character, digit)");
            string pass = "^(?=.*[^a-zA-Z\\d]).{8,16}$";
            foreach (string s in list)
            {
                bool isValid=Regex.IsMatch(s, pass);
                Console.WriteLine($"{s} is {(isValid ? "valid password" : "invalid password")}");
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("b. Phone Number - (345-4567-234)");
            List<string> values = new List<string>()
            {
                "345-4567-234",
                "22-2567-234",
                "123-32-1234",
                "232-2222-123",
            };
            string phone = @"^\d{3}-\d{4}-\d{3}";
            foreach (string s in values)
            {
                bool isValid= Regex.IsMatch(s, phone);
                Console.WriteLine($"{s} is {(isValid ? "Valid number" : "invalid number")}");
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("c. Mobile Number - (10 digits which should not accept 0 and 9)");
            List<string> strings = new List<string>()
            {
               "1234567876",
               "0123456789",
               "0987654321",
               "8765432123"
            };
            string pattern = "^[1-8].{9}$";
            foreach (string s in strings)
            {
                bool isvalid=Regex.IsMatch(s, pattern);
                Console.WriteLine($"{s} is {(isvalid ? "Valid phone number" : "invalid number")}");
            }
        }
    }
}
