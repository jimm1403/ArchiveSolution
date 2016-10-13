using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    public class Book : IThing
    {
        Book _book;
        bool status;
        string title;
        string year;
        string author;
        List<Book> bookList;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public bool Status
        {
            get { return status; }

            set { status = value; }
        }

        public void Add()
        {
            _book = new Book();
            bookList = new List<Book>();
            
            Console.WriteLine("Add the title of the book");
            _book.Title = Console.ReadLine();
            Console.WriteLine("Add the year the book was released");
            _book.Year = Console.ReadLine();
            Console.WriteLine("And last add the author of the book");
            _book.Author = Console.ReadLine();
            
            Console.WriteLine("Thank You. Now you have added one book");
            Console.WriteLine(_book.ToString());
            Console.ReadKey();
            
            StreamWriter outputFile;
            outputFile = File.AppendText("book.txt");
            outputFile.WriteLine(_book.ToString());
            outputFile.Close();

            Console.WriteLine("The name was written.");
            Console.ReadKey();
            Console.Clear();
        }
        public override string ToString()
        {
            return "The book: " + Title + ", " + Year + ", " + Author;
        }

        public void Search(string _searchWord)
        {
            string searchBook;
            StreamReader inputFile;
            inputFile = File.OpenText("book.txt");
            searchBook = inputFile.ReadToEnd();
        }
        public void Show()
        {
            string _aBook;

            StreamReader inputFile;

            inputFile = File.OpenText("book.txt");

            _aBook = inputFile.ReadToEnd();

            Console.WriteLine(_aBook);
            Console.ReadKey();
            Console.Clear();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

    }
}
