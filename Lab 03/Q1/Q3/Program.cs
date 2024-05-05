using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Product
    {
        public int ProductId { get; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product(int productId, string productName, double price, int quantityInStock)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public void AddProduct(int quantity)
        {
            QuantityInStock += quantity;
            Console.WriteLine(quantity + " " + ProductName + "(s) added to the inventory.");
        }

        public void BuyProduct(int quantity)
        {
            if (QuantityInStock >= quantity)
            {
                QuantityInStock -= quantity;
                Console.WriteLine(quantity + " " + ProductName + "(s) purchased.");
            }
            else
            {
                Console.WriteLine("Insufficient quantity in stock.");
            }
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine("Product ID: " + ProductId);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("Quantity in Stock: " + QuantityInStock);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(101, "Laptop", 800, 10);

            Console.WriteLine("Product Name: " + product.ProductName);
            Console.WriteLine("Price: $" + product.Price);
            Console.WriteLine("Quantity in Stock: " + product.QuantityInStock);

            // Attempting to modify the product's ID from external code
            // This will not work because ProductId is a private field
            //product.ProductId = 102; This line will generate a compiler error

            Console.ReadLine();
        }
    }
}