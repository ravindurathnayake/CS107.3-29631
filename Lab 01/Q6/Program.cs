using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: ");
            String name = Console.ReadLine();

            Console.Write("Enter Your Exam Marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());

            if (marks<0 || marks>100)
            {
                Console.WriteLine("\nERROR");
            }
            else if (marks >= 75)
            {
                Console.WriteLine($"\n{name} Grade is A");
            }
            else if (marks >= 60)
            {
                Console.WriteLine($"\n{name} Grade is B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine($"\n {name} Grade is C");
            }
            else if (marks >= 40)
            {
                Console.WriteLine($"\n{name} Grade is D");
            }
            else
            {
                Console.WriteLine($"\n {name} Grade is F");
            }   
            Console.ReadLine();
        }
    }
}
