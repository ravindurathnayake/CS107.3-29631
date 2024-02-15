using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Length of the Rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Width of the Rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double area = length * width;

            Console.WriteLine("The Area of the Rectangle is: " + area);  
            Console.ReadLine();
        }
    }
}
