using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace InventorySystemApp
{
    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Laptop", 420000);
            Product product2 = new Product("Mobilephone", 299900);
            Product product3 = new Product("EarBud", 45000);

            Console.WriteLine("Product Details:");
            Console.WriteLine("Product Name: " + product1.ProductName);
            Console.WriteLine("Price: Rs." + product1.Price);

            Console.WriteLine("\nProduct Name: " + product2.ProductName);
            Console.WriteLine("Price: Rs." + product2.Price);

            Console.WriteLine("\nProduct Name: " + product3.ProductName);
            Console.WriteLine("Price: Rs." + product3.Price);

            Console.Read();
        }
    }
}
