using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
    }
    internal class Lambdademo
    {
        public static void Main(string[] args)
        {
            List<Products> products = new List<Products>()
        {
            new Products() {id = 1,name="Shirt",price=499},
            new Products() {id=2,name="T-shirt",price=333},
            new Products() {id=3,name="Jeans",price=699},
            new Products() {id=4,name="Belt",price=459}
        };
            var list = from p in products orderby p.name descending select p;
            Console.WriteLine("The products in descending order");
            foreach (var item in list)
            {
                Console.WriteLine($"Product ID : {item.id}");
                Console.WriteLine($"Product Name : {item.name}");
                Console.WriteLine($"Product Price : {item.price}");
            }
            Console.WriteLine("Print any two properties of the list");
            var two = list.Select(p => new { p.price, p.name });
            foreach(var item in two)
            {
                Console.WriteLine($"price:{item.price} and name of the product is {item.name}");
            }
            Console.WriteLine("The first char of the product: ");
            var three = list.Select(p => (p.name[0]));
            foreach(var item in three)
            {
                Console.WriteLine($"first char of the product: {item}");
            }
        }
    }
}