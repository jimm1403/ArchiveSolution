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
        Entity entity = new Entity();
        string NL = Environment.NewLine;

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
                ShowMenu();
                choice = GetUserChoice();
                
                
                switch (choice)
                {
                    case "a": entity.Add(); break;
                    case "l": entity.List(); break;
                    case "s": entity.Search(); break;
                    case "d": entity.Delete(); break;
                    case "exit": run = false; break;
                    default: ShowMenuSelectionError(); break;
                }

            } while (run);  
        }
        private string GetUserChoice()
        {
            string userChoice = Console.ReadLine().ToLower(); ;
            return userChoice;
        }
        private void ShowMenu()
        {
            Console.WriteLine("ARCHIVE V.1" + NL + "You can archive(A), list(L) search(S) and delete(D)"
                + NL + "Books, Movies or Games that you own.");
        }
        private void ShowMenuSelectionError()
        {
            Console.WriteLine("Please try again(Click Enter)");
            Console.ReadKey();
            Console.Clear();
        }
        

        
    }
}
