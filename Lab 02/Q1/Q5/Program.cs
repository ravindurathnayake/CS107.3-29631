using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemApp
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; private set; }

        public LibraryBook(string title, string author)
        {
            Title = title;
            Author = author;
            Available = true;
        }

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine("You have borrowed the book: " + Title);
            }
            else
            {
                Console.WriteLine("Sorry, the book " + Title + " is not available.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibraryBook[] library = new LibraryBook[3];
            library[0] = new LibraryBook("The Nature & WildLife", "Ravindu Rathnayake");
            library[1] = new LibraryBook("The Jam Fruit Tree ", "Carl Muller");
            library[2] = new LibraryBook("Reef", "Romesh Gunathilaka");

            Console.WriteLine("Initial Library Status:");
            DisplayLibraryStatus(library);

            Console.WriteLine("\nBorrowing a book...");
            library[0].BorrowBook();

            Console.WriteLine("\nUpdated Library Status:");
            DisplayLibraryStatus(library);

            Console.ReadKey();
        }

        static void DisplayLibraryStatus(LibraryBook[] library)
        {
            foreach (LibraryBook book in library)
            {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Available: " + (book.Available ? "Yes" : "No"));
                Console.WriteLine();
            }
        }
    }
}