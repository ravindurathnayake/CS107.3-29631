using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please Enter 10 Number: \n");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($" Enter  Number {i}: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("Number is Even\n");
                }
                else
                {
                    Console.WriteLine("Number is Odd\n");
                }

            }
            Console.ReadLine();
        }
    }
}
