using ProductApp.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.SetId(1);
            product1.SetName("Product A");
            product1.SetPrice(1000);
            product1.SetDiscountPercent(10);
           
            Product product2 = new Product();
            product2.SetId(2);
            product2.SetName("Product B");
            product2.SetPrice(2000);
            product2.SetDiscountPercent(15);
           
            DisplayProduct(product1);
            Console.WriteLine();

            DisplayProduct(product2);
            Console.WriteLine();
        }
        static void DisplayProduct(Product product)
        { 
            Console.WriteLine("The id of the product is: " + product.GetId());
            Console.WriteLine("The name of the product is: " + product.GetName());
            Console.WriteLine("The price of the product is: " + product.GetPrice());
            Console.WriteLine("The discount percent offered is: " + product.GetDiscountPercent());
            Console.WriteLine("The price after discount is: " + product.DiscountCost());
        }
 
    }
}
