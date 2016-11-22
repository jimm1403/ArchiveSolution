using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    public class BookArchive
    {
        string NL = Environment.NewLine;
        DatabaseFacade dbf = new DatabaseFacade();
        UIFacade uif = new UIFacade();
        static void Main(string[] args)
        {
            BookArchive myBookArchive = new BookArchive();
            myBookArchive.Run();
        }

        public void Run()
        {
            string choice = "";
            bool run = true;
            
            do
            {
                Menu();
                choice = GetUserChoice();
                
                
                switch (choice)
                {
                    case "a": Add();            break;
                    case "l": List();           break;
                    case "s": Search();         break;
                    //case "d": ;               break;
                    case "exit": run = false;   break;
                    default: SelectionError();  break;
                }

            } while (run);  
        }
        void List()
        {
            Console.WriteLine(dbf.List());
            Console.ReadKey();
            Console.Clear();
        }
        void Search()
        {
            Console.WriteLine("Enter searchword");
            Console.WriteLine(dbf.Search());
            Console.ReadKey();
            Console.Clear();
        }
        void Add()
        {
            uif.UIAdd();
            Console.ReadKey();
            Console.Clear();
        }
        public string GetUserChoice()
        {
            string userChoice = Console.ReadLine().ToLower(); ;
            return userChoice;
        }
        private void Menu()
        {
            Console.WriteLine("ARCHIVE V.2" + NL + "You can archive(A), list(L) search(S) and delete(D)"
                + NL + "Books, Movies or Games that you own.");
        }
        private void SelectionError()
        {
            Console.WriteLine("Please try again(Click Enter)");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
