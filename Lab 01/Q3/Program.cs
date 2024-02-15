using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Positive Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for(int i=1;i<=num;i++)
            {
                
                if(num<0)
                {
                    Console.WriteLine("ERROR");
                    break;
                }
                else
                {
                    sum += i;
                }

            }
            if(sum>=0)
            {
                Console.WriteLine($"The Sum of the Numbers is : {sum}");
                
            }

            Console.ReadLine();

        }
    }
}
