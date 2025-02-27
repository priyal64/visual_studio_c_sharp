using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Book()
        {
            Console.WriteLine("i am default constructor");
        }
        public Book(string title ,string author):this()
        {
            Title = title;
            Author = author;
            Console.WriteLine("the book: " + Title + " AUTHOR :" + Author);
        }
        public Book(string title,string author,string isbn):this(title,author)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Console.WriteLine("book: " + Title + "Author :" + Author + "ISBN: " + ISBN);
        }
    }
}
