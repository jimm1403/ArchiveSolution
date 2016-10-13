using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    public class Movie : IThing
    {
        string title;
        string year;
        string author;
        bool status;
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

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Search(string _searchWord)
        {
            throw new NotImplementedException();
        }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
