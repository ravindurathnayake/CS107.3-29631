using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookApp
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            Book myBook = new Book();

           
            myBook.Title = "The Nature & WildLife";
            myBook.Author = "Ravindu Rathnayake";

            Console.WriteLine("Title: " + myBook.Title);
            Console.WriteLine("Author: " + myBook.Author);

            Console.ReadKey(); 
        }
    }
}