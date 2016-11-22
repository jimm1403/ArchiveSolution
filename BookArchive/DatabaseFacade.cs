using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    public class DatabaseFacade
    {
        public List<string> ReadFromFileToStringList()
        {
            StreamReader inputFile = new StreamReader("ListOfEntities.txt");
            List<string> searchLineList = new List<string>();
            string line;

            while ((line = inputFile.ReadLine()) != null)
            {
                searchLineList.Add(line);
            }
            inputFile.Close();

            return searchLineList;
        }
        public string Search()
        {
            BookArchive myBookArchive = new BookArchive();
            string _searchWord = myBookArchive.GetUserChoice();
            string searchEntity = "";
            List<string> searchLineList = ReadFromFileToStringList();
            
            foreach (var entity in searchLineList)
            {
                if (entity.Contains(_searchWord))
                {
                    searchEntity = entity;
                }
            }
            if (!searchEntity.Contains(_searchWord))
            {
                searchEntity = "Nothing found";
            }

            return searchEntity;
        }
        public string List()
        {
            string entity;

            StreamReader inputFile;
            inputFile = File.OpenText("ListOfEntities.txt");
            entity = inputFile.ReadToEnd();
            inputFile.Close();
            
            return entity;
        }
        public void WriteToFile()
        {
            UIFacade uif = new UIFacade();
            Entity entityToWrite = uif.UIAdd();
            
            StreamWriter outputFile;
            outputFile = File.AppendText("ListOfEntities.txt");
            outputFile.WriteLine(entityToWrite.ToString());
            outputFile.Close();
        }
    }
}
