using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookArchive
{
    interface IThing
    {
        void Add();
        void Show();
        void Delete();
        void Search(string _searchWord);
        string Title { get; set; }
        string Year { get; set; }
        string Author { get; set; }
        bool Status { get; set; }

    }
}
