using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    class BookArchive
    {
        
        static void Main(string[] args)
        {
            BookArchive myBookArchive = new BookArchive();
            myBookArchive.Run();
        }

        public void Run()
        {
            List<IThing> listOfThing = new List<IThing>();
            IThing book = new Book();
            IThing movie = new Movie();
            IThing game = new Game();
            Book newBook = new Book();
            string choice = "";
            bool run = true;
            
            do
            {
                ShowMenu();
                choice = GetUserChoice();
                switch (choice)
                {
                    case "show book": newBook.Show(); break;
                    case "add book": newBook.Add(); break;
                    case "exit": run = false; break;
                    default: ShowMenuSelectionError(); break;
                }

            } while (run);  
        }
        private string GetUserChoice()
        {
            string userChoice = Console.ReadLine();
            return userChoice;
        }

        private void ShowMenu()
        {
            Console.WriteLine("Add, show or search");
        }

        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Please try again(Click Enter)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
