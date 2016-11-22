using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    public class UIFacade
    {
        public Entity UIAdd()
        {
            Console.WriteLine("What are you archiving?");
            string subject = Console.ReadLine();
            Console.WriteLine("Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Release year:");
            string year = Console.ReadLine();
            Console.WriteLine("Author:");
            string author = Console.ReadLine();
            Console.WriteLine("Thank You.");

            Entity newEntity = new Entity(subject, title, year, author);

            return newEntity;
        }
    }
}
