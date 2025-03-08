
//**Constructor Overloading in a Library System**Implement a `Book` class with three different constructors:
//(1) Default constructor, (2) Constructor with `Title` and `Author`, (3) Constructor with `Title`, `Author`, and
//`ISBN`. Ensure each constructor initializes properties correctly.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book()
        {
            Title = "Wings of Fire";
            Author = "A.P.J. Abdul Kalam";
            ISBN = "100045";
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "125670987";
        }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
        static void Main()
        {
            Book book1 = new Book();
            Book book2 = new Book("Mahabharata", "Vyasa");
            Book book3 = new Book("Ramayana", "Valmiki", "1224935");

            book1.DisplayBookInfo();
            book2.DisplayBookInfo();
            book3.DisplayBookInfo();
        }

    }
}
