using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    public class Entity
    {
        string NL = Environment.NewLine;
        Entity entity;
        bool status;
        string title;
        string year;
        string author;
        string subject;
        
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
        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public bool Status
        {
            get { return status; }

            set { status = value; }
        }
        
        public void Add()
        {
            entity = new Entity();

            Console.WriteLine("What are you archiving?");
            entity.Subject = Console.ReadLine();
            Console.WriteLine("Title:");
            entity.Title = Console.ReadLine();
            Console.WriteLine("Release year:");
            entity.Year = Console.ReadLine();
            Console.WriteLine("Author:");
            entity.Author = Console.ReadLine();
            
            Console.WriteLine("Thank You.");
            Console.ReadKey();
            
            StreamWriter outputFile;
            outputFile = File.AppendText("ListOfEntities.txt");
            outputFile.WriteLine(entity.ToString());
            outputFile.Close();

            Console.Clear();
        }
        public override string ToString()
        {
            return Subject + ": " + Title + ", " + Year + ", " + Author;
        }

        public void Search()
        {
            Console.WriteLine("Enter searchword:");
            string _searchWord = Console.ReadLine();

            List<string> searchLineList = new List<string>(); 
            int counter = 0;
            string line;
            StreamReader inputFile = new StreamReader("ListOfEntities.txt");
            
            while ((line = inputFile.ReadLine()) != null)
            {
                searchLineList.Add(line);
                counter++;
            }

            foreach (var entity in searchLineList)
            {
                if (entity.Contains(_searchWord))
                {
                    Console.WriteLine(entity);
                }
            }
            Console.ReadKey();
            Console.Clear();

        }
        public void List()
        {
            string entity;

            StreamReader inputFile;
            inputFile = File.OpenText("ListOfEntities.txt");
            entity = inputFile.ReadToEnd();
            //inputFile.Close();
            Console.WriteLine(entity);
            Console.ReadKey();
            Console.Clear();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

    }
}
