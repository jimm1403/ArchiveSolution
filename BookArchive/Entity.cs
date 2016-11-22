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
        string title;
        string year;
        string author;
        string subject;
        public Entity()
        {

        }
        public Entity(string subject, string title, string year, string author)
        {
            this.subject = subject;
            this.title = title;
            this.year = year;
            this.author = author;
        }
        public override string ToString()
        {
            return subject + ": " + title + ", " + year + ", " + author;
        }
    }
}
